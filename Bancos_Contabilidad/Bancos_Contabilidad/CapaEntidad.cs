﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bancos_Contabilidad
{
    class CapaEntidad
    {

        public static string idemp;
        public class poliza{
            string ID;
            string nombre;
            string total;
            string fecha;
            string cuenta;
            string empresa;
            string status;

            public string Nombre
            {
                get
                {
                    return nombre;
                }

                set
                {
                    nombre = value;
                }
            }

            public string Total
            {
                get
                {
                    return total;
                }

                set
                {
                    total = value;
                }
            }

            public string Fecha
            {
                get
                {
                    return fecha;
                }

                set
                {
                    fecha = value;
                }
            }

            public string Cuenta
            {
                get
                {
                    return cuenta;
                }

                set
                {
                    cuenta = value;
                }
            }

            public string Empresa
            {
                get
                {
                    return empresa;
                }

                set
                {
                    empresa = value;
                }
            }

            public string ID1
            {
                get
                {
                    return ID;
                }

                set
                {
                    ID = value;
                }
            }

            public string Status
            {
                get
                {
                    return status;
                }

                set
                {
                    status = value;
                }
            }
        }

        public class DocumentoRef{
            string ID;
            string Documento;
            string Descripcion;
            string total;
            string fecha;
            string estado;

            public string ID1
            {
                get
                {
                    return ID;
                }

                set
                {
                    ID = value;
                }
            }

            public string Documento1
            {
                get
                {
                    return Documento;
                }

                set
                {
                    Documento = value;
                }
            }

            public string Descripcion1
            {
                get
                {
                    return Descripcion;
                }

                set
                {
                    Descripcion = value;
                }
            }

            public string Total
            {
                get
                {
                    return total;
                }

                set
                {
                    total = value;
                }
            }

            public string Fecha
            {
                get
                {
                    return fecha;
                }

                set
                {
                    fecha = value;
                }
            }

            public string Estado
            {
                get
                {
                    return estado;
                }

                set
                {
                    estado = value;
                }
            }
        }


    }
}