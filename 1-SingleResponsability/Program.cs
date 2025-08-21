using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHelper = new();
exportHelper.ExportStudents(studentRepository.GetAll(), "Students.csv");
exportHelper.ExportData(studentRepository.GetAll(), "Data.csv");

Console.WriteLine("Proceso Completado");