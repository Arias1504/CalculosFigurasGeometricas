using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculosGeometricos;

namespace FigurasGeometricas
{
    public class Geometria
    {
        public class Esfera : FiguraGeometrica
        {
            private float _radio;

            public Esfera(float radio)
            {
                _radio = radio;
                area = 0;
                volumen = 0;
                error = string.Empty;
            }

            public float Radio
            {
                set { _radio = value; }
            }

            private bool Validar()
            {
                if (_radio <= 0)
                {
                    error = "Error, valor del radio no valido";
                    return false;
                }
                return true;
            }

            public override bool HallarArea()
            {
                try
                {
                    if (!Validar())
                        return false;

                    area = 4f * (float)(Math.PI * Math.Pow(_radio, 2));
                    return true;
                }
                catch(Exception ex)
                {
                    error = ($"Error inesperado {ex.Message} reintente por favor");
                    return false;
                }
            }

            public override bool HallarVolumen()
            {
                try
                {
                    if (!Validar())
                        return false;

                    volumen = 4/3f * (float)(Math.PI * Math.Pow(_radio, 3));
                    return true;
                }
                catch (Exception ex)
                {
                    error = ($"Error inesperado {ex.Message} reintente por favor");
                    return false;
                }
            }
        }

        public class Cilindro : FiguraGeometrica
        {
            private float _radio;
            private float _altura;

            public Cilindro(float radio, float altura)
            {
                _radio = radio;
                _altura = altura;
                area = 0;
                volumen = 0;
            }

            public float Radio
            {
                set { _radio = value; }
            }

            public float Altura
            {
                set { _altura = value; }
            }

            private bool Validar()
            {
                if(_radio <= 0)
                {
                    error = "Error, valor del radio no valido";
                    return false;
                }
                if(_altura <= 0)
                {
                    error = "Error, valor de la altura no valido";
                    return false;
                }
                return true;
            }

            public override bool HallarArea()
            {
                try
                {
                    if (!Validar())
                        return false;

                    area = Convert.ToSingle(2f * Math.PI * _radio * (_altura + _radio));
                    return true;
                }
                catch (Exception ex)
                {
                    error = ($"Error inesperado {ex.Message} reintente por favor");
                    return false;
                }
            }

            public override bool HallarVolumen()
            {
                try
                {
                    if (!Validar())
                        return false;

                    volumen = Convert.ToSingle(Math.PI * Math.Pow(_radio, 2) * _altura);
                    return true;
                }
                catch(Exception ex)
                {
                    error = ($"Error inesperado {ex.Message} reintente por favor");
                    return false;
                }
            }
        }

        public class Paralelepipedo : FiguraGeometrica
        {
            private float _ladoA;
            private float _ladoB;
            private float _ladoC;

            public Paralelepipedo(float ladoA, float ladoB, float ladoC)
            {
                _ladoA = ladoA;
                _ladoB = ladoB;
                _ladoC = ladoC;
            }

            public float LadoA
            {
                set { _ladoA = value; }
            }
            public float LadoB
            {
                set { _ladoB = value; }
            }
            public float LadoC
            {
                set { _ladoC = value; }
            }

            private bool Validar()
            {
                if (_ladoA <= 0 || _ladoB <= 0 || _ladoC <= 0)
                {
                    error = "Error, valor no valido";
                    return false;
                }
                return true;
            }

            public override bool HallarArea()
            {
                try
                {
                    if (!Validar())
                        return false;

                    area = 2f * (_ladoA * _ladoB + _ladoA * _ladoC + _ladoB * _ladoC);
                    return true;
                }
                catch (Exception ex)
                {
                    error = ($"Error inesperado {ex.Message} reintente por favor");
                    return false;
                }
            }

            public override bool HallarVolumen()
            {
                try
                {
                    if (!Validar())
                        return false;

                    volumen = _ladoA * _ladoB * _ladoC;
                    return true;
                }
                catch (Exception ex)
                {
                    error = ($"Error inesperado {ex.Message} reintente por favor");
                    return false;
                }
            }

        }
    }
}
