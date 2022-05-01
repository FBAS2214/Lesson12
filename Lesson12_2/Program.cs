using System;

/*
namespace Lesson12_2
{
    public delegate void NumberControlHandler();


    class Number
    {

        // public event NumberControlHandler? OnChanged
        // {
        //     add { Console.WriteLine("add operation"); }
        //     remove { Console.WriteLine("remove operation"); }
        // }


        public event NumberControlHandler? OnChanged = null;

        private int _value;

        public int Value
        {
            get { return _value; }
            set {
                if (value < 0) OnChanged?.Invoke();
                else _value = value; 
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Number number = new Number();
            number.OnChanged += ControlNegativeNumber;
            // number.OnChanged -= ControlNegativeNumber;
            // number.OnChanged = () => { Console.WriteLine("Error"); };
           
            
            number.Value = -1;
            Console.WriteLine(number.Value);
        }


        private static void ControlNegativeNumber()
        {
            Console.WriteLine("Number can't be less than 0");
        }
    }
}
*/










namespace Lesson11_2
{
    public delegate void NotificationHandler(string sender, string text);




    class StepComputerAcademy
    {
        public event NotificationHandler? OnNotify = null;

        public void Publish(string? text)
        {
            OnNotify?.Invoke("STEP IT", text ?? "");
            //// or
            // OnNotify("STEP IT", text ?? "");
        }
    }







    interface INotificationService
    {
        public bool IsActive { get; set; }

        public void GetNotification(string sender, string text);

    }




    class Email : INotificationService
    {
        public bool IsActive { get; set; }

        public void GetNotification(string sender, string text)
        {
            Console.WriteLine("\nYou have got email");
            Console.WriteLine($"From : {sender}");
            Console.WriteLine($"Date : {DateTime.Now}");
            Console.WriteLine("No Subject");
            Console.WriteLine($"Body : {text}");
        }
    }


    class MobileClient : INotificationService
    {
        public bool IsActive { get; set; }
        
        public void GetNotification(string sender, string text)
        {
            Console.Beep();
            Console.WriteLine($"\nSender : {sender} : {text}");
        }
    }


    class SMS : INotificationService
    {
        public bool IsActive { get; set; }
        public void GetNotification(string sender, string text)
        {
            Console.WriteLine($"\nNew SMS : {sender}  -  {text}");
        }
    }




    class Program
    {
        public static StepComputerAcademy Application { get; set; } = new StepComputerAcademy();

        static void Main()
        {
            var email = new Email();
            var sms = new SMS();
            var mobile = new MobileClient();



            char ch = '\0';

            while (ch != '5')
            {
                Console.Clear();
                Console.WriteLine("1.Publish Something");
                Console.WriteLine($"2.Email : {(email.IsActive ? "Unsubscribe" : "Subscribe")}");
                Console.WriteLine($"3.SMS : {(sms.IsActive ? "Unsubscribe" : "Subscribe")}");
                Console.WriteLine($"4.Mobile : {(mobile.IsActive ? "Unsubscribe" : "Subscribe")}");
                Console.WriteLine($"5.Exit");

                ch = Console.ReadKey().KeyChar;

                switch (ch)
                {
                    case '1':
                        {
                            Console.Clear();
                            Console.Write("Write Text: ");
                            string? text = Console.ReadLine();
                            Application.Publish(text);
                            Console.ReadKey(true);
                            break;
                        }

                    case '2':
                        {
                            ChangeState(email);
                            break;
                        }
                    case '3':
                        {
                            ChangeState(sms);
                            break;
                        }
                    case '4':
                        {
                            ChangeState(mobile);
                            break;
                        }
                }
            }
        }


        public static void ChangeState(INotificationService service)
        {
            if (service.IsActive) Application.OnNotify -= service.GetNotification;
            else Application.OnNotify += service.GetNotification;

            service.IsActive = !service.IsActive;
        }
    }


}