

namespace SystemaDeNomina
{
    public abstract class Empleado
    {
        public string primerNombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string numerodeSeguroSocial { get; set; }



        public Empleado() { //Default Builder
        
        }

        public virtual void getDatos()   //Asignar atributos
        {


            Console.Write("Ingrese el primer nombre: ");
            primerNombre = Console.ReadLine();

            primerNombre = string.IsNullOrEmpty(primerNombre) ? "Nombre (VACÍO)" : primerNombre;


            Console.Write("Ingrese el apellido paterno: ");
            apellidoPaterno = Console.ReadLine();
            
            apellidoPaterno = string.IsNullOrEmpty(apellidoPaterno) ? "Apellido (VACÍO)" : apellidoPaterno;


            Console.Write("Ingrese el número de seguro social: ");
            numerodeSeguroSocial = Console.ReadLine();

            numerodeSeguroSocial = string.IsNullOrEmpty(numerodeSeguroSocial) ? "Campo vacío" : numerodeSeguroSocial;



        }


        public abstract decimal CalcularIngreso(); 


        public override string ToString()  //ToString override
        {
            return $"{primerNombre} {apellidoPaterno} \nNúmero de Seguro Social: {numerodeSeguroSocial}";
        }
    }



}
