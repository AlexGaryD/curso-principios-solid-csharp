using System.Text;

namespace SingleResponsability
{
    public class ExportHelper
    {
        public void ExportStudents(IEnumerable<Student> students, string v)
        {
            // Implementación de la exportación de estudiantes
            string csv = String.Join(",", students.Select(x => x.ToString()).ToArray());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("Id;Fullname;Grades");
            foreach (var item in students)
            {
                sb.AppendLine($"{item.Id};{item.Fullname};{string.Join("|", item.Grades)}");
            }
            System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"), sb.ToString(), Encoding.Unicode);
        }
        public void ExportData<T>(IEnumerable<T> data, string fileName)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            // 🎯 LÍNEA 12 - HEADER ESPECÍFICO DE STUDENT
            sb.AppendLine("Id;Fullname;Grades");

            foreach (var item in data.OfType<Student>()) // ✅ CORRECTO: filtrar por tipo Student
            {
                // 🎯 LÍNEA 14 - ACCESO A PROPIEDADES ESPECÍFICAS DE STUDENT
                sb.AppendLine($"{item.Id};{item.Fullname};{string.Join("|", item.Grades)}");
            }

            // 🎯 LÍNEA 16 - NOMBRE DE ARCHIVO ESPECÍFICO
            System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data.csv"), sb.ToString(), Encoding.Unicode);
        }

    }
}