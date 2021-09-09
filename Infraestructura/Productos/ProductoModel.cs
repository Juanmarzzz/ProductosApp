using Dominio.Entidades;
using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Productos
{
    public class ProductoModel
    {
        private Producto[] Productos;

        #region CRUD 
        //Create, Read, Update and Delete
        public void Add(Producto p)
        {
            if (p == null)
            {
                throw new ArgumentException("El producto no puede ser null");
            }

            Add(p, ref Productos);
        }

        public int Actualizar(Producto p)
        {
            if (p == null)
            {
                throw new ArgumentException("El producto no puede ser null");

            }
            int index = GetIndexById(p.Id);
            if(index < 0)
            {
                throw new Exception($"El producto co id:{p.Id} no existe");
            }

            Productos[index] = p;

            return index;
             
        }

        public bool Eliminar(Producto p)
        {
            if (p == null)
            {
                throw new ArgumentException("El producto no puede ser null");

            }
            int index = GetIndexById(p.Id);
            if (index < 0)
            {
                throw new Exception($"El producto co id:{p.Id} no existe");
            }

            if(index != Productos.Length -1)
            {
                Productos[index] = Productos[Productos.Length - 1];
            }
            Producto[] tmp = new Producto[Productos.Length + 1];
            Array.Copy(Productos, tmp, Productos.Length);
            tmp[tmp.Length - 1] = p;
            Productos = tmp;

            return Productos.Length == tmp.Length;
        }

        public Producto[] GetAll()
        {
            return Productos;
        }
        #endregion

        //========================================================================================================================

        #region Consultas
        public Producto GetProductoById(int id)
        {
            int index = GetIndexById(id);
            return index < 0 ? null : Productos[index];
        }

        public Producto[] GetProductosByUnidadMedida(UnidadMedida um)
        {
            Producto[] tmp = null;
            if(Productos == null)
            {
                return tmp;
            }
            foreach (Producto p in Productos)
            {
                if (p.UnidadMedida == um)
                {
                    Add(p, ref tmp);
                }
            }
            return tmp;
        }

        public Producto[] GetProductosByRangoPrecio(decimal from, decimal to)
        {
            Producto[] tmp = null;
            if (Productos == null)
            {
                return tmp;
            }
            foreach (Producto p in Productos)
            {
                if (p.Precio >= from && p.Precio <= to)
                {
                    Add(p, ref tmp);
                }
            }
            return tmp;
        }

        public Producto[] GetProductosByVencimiento(DateTime dt)
        {
            Producto[] tmp = null;
            if (Productos == null)
            {
                return tmp;
            }
            foreach (Producto p in Productos)
            {
                if (p.FechaVencimiento.CompareTo(dt) <= 0)
                {
                    Add(p, ref tmp);
                }
            }
            return tmp;
        }

        public int GetLastProductoId()
        {
            return Productos == null ? 0 : Productos[Productos.Length - 1].Id;
        }
        /*
        public string GetProducoAsJson()
        {

        }
        */
        #endregion

        //========================================================================================================================

        #region Metodo Privado Add
        private void Add(Producto p, ref Producto[] pds)
        {
            if (pds == null)
            {
                pds = new Producto[1];
                pds[pds.Length - 1] = p;
                return;
            }

            Producto[] tmp = new Producto[pds.Length + 1];
            Array.Copy(pds, tmp, pds.Length);
            tmp[tmp.Length - 1] = p;
            pds = tmp;
        }

        private int GetIndexById(int id)
        {

            int index = int.MinValue, i = 0;

            if (id <= 0)
            {
                throw new ArgumentException($"El Id:{id} no puede menor o igual que 0");
            }

            if (Productos == null)
            {
                return index;
            }

            foreach (Producto p in Productos)
            {
                if(p.Id == id)
                {
                    index = i;
                    break;
                }
                i++;
            }
            return index;
        }
        #endregion

    }
}
