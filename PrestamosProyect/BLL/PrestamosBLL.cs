using Microsoft.EntityFrameworkCore;
using PrestamosProyect.DAL;
using PrestamosProyect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PrestamosProyect.BLL
{
    public class PrestamosBLL
    {
        
        
            public static bool Guardar(Prestamos prestamo)
            {
            if (!Existe(prestamo.PrestamoId))
                return Insertar(prestamo);
            else
                return Modificar(prestamo);
        }

        private static bool Insertar(Prestamos prestamo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            Personas persona = PersonasBLL.Buscar(prestamo.PersonaId);

            try
            {
                prestamo.Balance += prestamo.Monto;
                persona.Balance += prestamo.Monto;
                contexto.Entry(persona).State = EntityState.Modified;

                contexto.Prestamos.Add(prestamo);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

            public static bool Modificar(Prestamos prestamoActual)
            {
                bool paso = false;
                double auxiliar = 0;
                Contexto contexto = new Contexto();

                try
                {
                    Personas persona = PersonasBLL.Buscar(prestamoActual.PersonaId);
                    Prestamos prestamoAnterior = PrestamosBLL.Buscar(prestamoActual.PrestamoId);
                    prestamoActual.Balance = prestamoActual.Monto;

                    if (prestamoActual.Monto > prestamoAnterior.Monto)
                    {
                        auxiliar = prestamoActual.Monto - prestamoAnterior.Monto;
                        persona.Balance += auxiliar;
                    }
                    else
                    {
                        auxiliar = prestamoAnterior.Monto - prestamoActual.Monto;
                        persona.Balance -= auxiliar;
                    }

                    contexto.Entry(persona).State = EntityState.Modified;
                    contexto.Entry(prestamoActual).State = EntityState.Modified;
                    paso = contexto.SaveChanges() > 0;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    contexto.Dispose();
                }

                return paso;
            }

            public static bool Eliminar(int id)
            {
            bool paso = false;

            Contexto contexto = new Contexto();



            try

            {

                var Prestamo = contexto.Prestamos.Find(id);

                if (Prestamo != null)

                {

                    contexto.Personas.Find(Prestamo.PersonaId).Balance -= Prestamo.Balance;

                    contexto.Prestamos.Remove(Prestamo);//remueve la entidad

                    paso = contexto.SaveChanges() > 0;



                }

            }

            catch (Exception)

            {

                throw;

            }

            finally

            {

                contexto.Dispose();

            }

            return paso;
        }

            public static Prestamos Buscar(int id)
            {
                Prestamos prestamo;
                Contexto contexto = new Contexto();

                try
                {
                    prestamo = contexto.Prestamos.Find(id);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    contexto.Dispose();
                }

                return prestamo;
            }

            public static List<Prestamos> GetList(Expression<Func<Prestamos, bool>> prestamo)
            {
                List<Prestamos> Lista = new List<Prestamos>();
                Contexto contexto = new Contexto();

                try
                {
                    Lista = contexto.Prestamos.Where(prestamo).ToList();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    contexto.Dispose();
                }

                return Lista;
            }

            public static List<Prestamos> GetList()
            {
                List<Prestamos> Lista = new List<Prestamos>();
                Contexto contexto = new Contexto();

                try
                {
                    Lista = contexto.Prestamos.ToList();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    contexto.Dispose();
                }

                return Lista;
            }

            public static bool Existe(int id)
            {

            bool encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.Prestamos.Any(e => e.PrestamoId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }
        }
    }

