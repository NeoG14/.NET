using CalculoSimple;

//Ilogger logger = new LoggerArchivo();
Ilogger logger = new Logger();
Calculador calc = new Calculador(logger);
calc.Calcular(3);



Console.ReadLine();
