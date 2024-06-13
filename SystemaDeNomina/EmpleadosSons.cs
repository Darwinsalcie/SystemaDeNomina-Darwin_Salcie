


namespace SystemaDeNomina
{

    #region EmpleadoAsalariado
    public class EmpleadoAsalariado : Empleado
    {
        public decimal salarioSemanal {  get; set; }
        public override void getDatos()
        {
            base.getDatos();
            Console.Write("Ingrese el salario semanal: ");                  //se agrega perdir el salario al metodo getDatos

            try{

                salarioSemanal = Convert.ToDecimal(Console.ReadLine());
            }

            catch(Exception) {
            
                salarioSemanal=0;
            
            }

        }

        public override decimal CalcularIngreso()
        {
            return salarioSemanal;
        }
        
        
        public override string ToString()                     //Se modifica la función ToString
        {
            return $"Empleado asalariado: {base.ToString()}\nSalario semanal: {salarioSemanal:C}";
        }
    }

    #endregion


    #region EmpleadorPorHoras
    public class EmpleadoPorHoras : Empleado
    {

        public decimal sueldoPorHoras { get; set; }
        public decimal horasTrabajadas { get; set; }
        public decimal salario { get; set; }


        public override void getDatos()
        

        {
            base.getDatos();                                                    //se agregan más cosas al metodo getDatos 
            
            Console.Write("Ingrese el sueldo por horas:");

            try
            {

                sueldoPorHoras = Convert.ToDecimal(Console.ReadLine());
            }

            catch (Exception)
            {

                sueldoPorHoras = 0;

            }

            Console.Write("Ingrese la cantidad de horas trabajadas:");

            try 
            {
                horasTrabajadas = Convert.ToDecimal(Console.ReadLine());   
            
            }

            catch (Exception)
            {
                horasTrabajadas=0;
            }

        }

        public override decimal CalcularIngreso()
        {
            salario = sueldoPorHoras * horasTrabajadas;




            if (horasTrabajadas <= 40)
            {
                salario = sueldoPorHoras * horasTrabajadas;
            }
            else if (horasTrabajadas < 0)
            {
                salario = -horasTrabajadas * sueldoPorHoras;
            }

            else
            {
                salario = (40 * sueldoPorHoras) + ((horasTrabajadas - 40) * ((3 * sueldoPorHoras) / 2));    // 3*sueldoPorHoras  = sueldoPorHoras * 1.5
            }


            return salario;
        }


        public override string ToString()
        {
            return $"Empleado pagado por Horas: {base.ToString()}\nhoras trabajadas: {horasTrabajadas}\nSueldo por hora: {sueldoPorHoras}";
        }
    }



    #endregion


    #region EmpleadoPorComision
    public class EmpleadoPorComision : Empleado
    {
        public decimal comisión { get; set; }
        public decimal ventasBrutas { get; set; }
        public decimal tarifaComision { get; set; }

        public override void getDatos()
        {
            base.getDatos();
            Console.Write("Ingrese las ventas brutas: ");                  //se agrega perdir el salario al metodo getDatos



            try
            {

                ventasBrutas = Convert.ToDecimal(Console.ReadLine());
            }

            catch (Exception)
            {

                ventasBrutas = 0;

            }

            Console.Write("Ingrese tarifa por comisión: ");

            try
            {

                tarifaComision = Convert.ToDecimal(Console.ReadLine());
            }

            catch (Exception)
            {

                tarifaComision = 0;

            }
        }

        public override decimal CalcularIngreso()
        {
            

            comisión = tarifaComision*ventasBrutas;
            
            
            return comisión;
        }


        public override string ToString()
        {
            return $"Empleado pagado por comisión: {base.ToString()}\nTarfia por comisión: {tarifaComision}\nVentas brutas:{ventasBrutas:C}";
        }
    }

    #endregion


    #region EmpleadosMasComisión

    public class EmpleadoBaseMasComision : EmpleadoPorComision
    {
        public decimal basemasComisión { get; set; }
    
        public decimal sueldoBase { get; set; }

        public override void getDatos() 
        {

            base.getDatos() ;

            Console.Write("Ingrese el sueldo base:");
            try
            {
                sueldoBase = Convert.ToDecimal(Console.ReadLine());
            }

            catch (Exception)
            {
                sueldoBase = 0;

            }

        }



        public override decimal CalcularIngreso() 
        {
            
            basemasComisión = sueldoBase + base.CalcularIngreso();

            return basemasComisión;
        
        }
 


        public override string ToString()
        {
            return $"Empleado pagado por comisión: {base.ToString()}\nSueldo base: {sueldoBase}\nVentas brutas: {ventasBrutas:C}\nComisión: {base.CalcularIngreso()}";
        }

    }

    #endregion

}