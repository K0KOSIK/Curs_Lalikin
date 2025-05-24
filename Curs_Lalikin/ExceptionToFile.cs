using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_Lalikin
{
    internal class ExceptionToFile
    {
        public static void SaveExceptionToDesktop(Exception ex, string fileName = "error_log.txt")
        {
            // Получаем путь к рабочему столу
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, fileName);

            // Формируем информацию об ошибке
            StringBuilder errorInfo = new StringBuilder();
            errorInfo.AppendLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}]");
            errorInfo.AppendLine($"Тип ошибки: {ex.GetType().Name}");
            errorInfo.AppendLine($"Сообщение: {ex.Message}");
            errorInfo.AppendLine($"Стек вызовов: {ex.StackTrace}");

            // Рекурсивно обрабатываем внутренние исключения
            Exception innerEx = ex.InnerException;
            while (innerEx != null)
            {
                errorInfo.AppendLine("\n--- Внутреннее исключение ---");
                errorInfo.AppendLine($"Тип: {innerEx.GetType().Name}");
                errorInfo.AppendLine($"Сообщение: {innerEx.Message}");
                errorInfo.AppendLine($"Стек: {innerEx.StackTrace}");
                innerEx = innerEx.InnerException;
            }
            errorInfo.AppendLine(new string('=', 50));

            // Записываем в файл
            try
            {
                File.AppendAllText(filePath, errorInfo.ToString(), Encoding.UTF8);
                Console.WriteLine($"Файл сохранен: {filePath}");
            }
            catch (Exception fileEx)
            {
                Console.WriteLine($"Ошибка записи в файл: {fileEx.Message}");
            }
        }
    }
}
