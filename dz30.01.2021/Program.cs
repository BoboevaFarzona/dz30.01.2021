using System;

namespace dz30._01._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            const string pro = "pro";
            const string exp = "exp";
            Console.WriteLine("Введите лицензионный ключ");
            string key = Console.ReadLine();
            DocumentWorker document = new DocumentWorker();
            if ( key== pro)
            {
                Console.WriteLine(document=new DocumentWorker());
            }
            else if(key==exp)
            {
                Console.WriteLine(document= new ExpertDocumentWorker());
            }
            else { Console.WriteLine(document=new DocumentWorker()); }

            Console.WriteLine("  Введите комаанды для работы с документом :\n 1: Открыть документ,\n 2:Редактировать документ, \n 3:-Сохранить ,\n 4:-выход ");

            bool b = true;
            while (b == true)
            {
                switch (Console.ReadLine())
                {
                    case "1": Console.ForegroundColor = ConsoleColor.Blue; document.OpenDocument(); Console.ForegroundColor = ConsoleColor.White; break;
                    case "2": Console.ForegroundColor = ConsoleColor.Blue; document.EditDocument(); Console.ForegroundColor = ConsoleColor.White; break;
                    case "3": Console.ForegroundColor = ConsoleColor.Blue; document.SaveDocument(); Console.ForegroundColor = ConsoleColor.White; break;
                    case "4": b = false; Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Выход"); Console.ForegroundColor = ConsoleColor.White; break;
                    default: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Неправильная команда!"); Console.ForegroundColor = ConsoleColor.White; break;
                }
            }
           
        }
    }
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
    class ProDocumentWorker : DocumentWorker
    {
        public override void  EditDocument()
         {
            Console.WriteLine("Документ отредактирован");
         }
         public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате.");
        }

    }
}


////dz2
///using System;

namespace ConsoleApp12
{
    class Program
    {

        static void Main(string[] args)
        {
            IPlayable playable = new Player();
            IRecordable recordable = new Player();

            playable.Play();
            recordable.Record();
            playable.Pause();
            recordable.Record();
        }

    }

    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }
    class Player : IRecordable, IPlayable
    {

        public void Play()
        {

            Console.WriteLine("Видео воспроизводится");
        }
        public void Pause()
        {
            Console.WriteLine("Видео поставлено на паузу");
        }
        public void Stop()
        {
            Console.WriteLine("Стоп");
        }
        public void Record()
        {
            Console.WriteLine("Видео записывается ");
        }
    }
}


