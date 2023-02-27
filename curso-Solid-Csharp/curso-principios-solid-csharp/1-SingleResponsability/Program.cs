using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHelper = new();
studentRepository.Export();
Console.WriteLine("Proceso Completado");