using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TPL_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //TaskIstFertigEvent += LogikNachDemTask;
        }

        private CancellationTokenSource cts = new CancellationTokenSource();
        //private void LogikNachDemTask(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Ende");
        //}

        //public event EventHandler TaskIstFertigEvent;

        private async void ButtonTPL_Click(object sender, RoutedEventArgs e)
        {
            #region Task Warten
            //Task<string> gibZeit = new Task<string>(() =>
            //{
            //   Thread.Sleep(5000);
            //   return DateTime.Now.ToLongTimeString();
            //});

            //gibZeit.Start();

            ////Task.WaitAll(t1,t2,t3)
            ////Task.WaitAny(t1,t2,t3)
            //gibZeit.Wait();

            //string ergebnis = gibZeit.Result; // Wartet automatisch sofern das Ergebnis noch nicht da ist

            //MessageBox.Show(ergebnis); 
            #endregion

            #region Tasks und Exceptions
            //Task t1 = new Task(() =>
            //{
            //    throw new FormatException("Falsche Eingabe !!!");
            //});
            //t1.Start();

            //Task t2 = Task.Factory.StartNew(() =>
            //{
            //    throw new DivideByZeroException("Nicht durch 0 !!!");
            //});

            //Task t3 = Task.Run(() =>
            //{
            //   throw new NullReferenceException("Gibts nicht !!");
            //});

            //try
            //{
            //    Task.WaitAll(t1, t2, t3);
            //}
            //catch (AggregateException ex)
            //{
            //    var flat = ex.Flatten();
            //    flat.Handle(specificEx =>
            //   {
            //       switch (specificEx)
            //       {
            //           case FormatException x:
            //               Console.WriteLine(x.Message);
            //               return true;
            //           case DivideByZeroException x:
            //               Console.WriteLine(x.Message);
            //               return true;
            //           //case NullReferenceException x:
            //           //    Console.WriteLine(x.Message);
            //           //    return true;
            //           default: // Unbekannt
            //               return false;
            //       }
            //   });
            //}

            ////// maximal 2 Kerne nutzen
            ////Parallel.For(0, 100,new ParallelOptions { MaxDegreeOfParallelism = 2 }, i =>
            ////  {
            ////    // .....
            ////  });

            ////Parallel.Invoke(Methode1,Methode2,Methode3 ....) 
            #endregion

            #region Tasks mit async/await
            //MessageBox.Show("Start");

            //// Variante 1: Synchron
            ////string x = GibZeitMethodeAsync().Result;

            //// Variante 2: Asynchron
            //string x = await GibZeitMethodeAsync();
            //MessageBox.Show(x); 
            #endregion

            try
            {
              await GibFehlerMethodeAsync();
            }
            catch (Exception)
            {
                MessageBox.Show("Task is ded");
            }

            MessageBox.Show("Ende");
        }
        
        // Task // void
        // Task<T>
        // void <----- NIE VERWENDEN !!! (Ausnahme: Eventhandler im CodeBehind, da es aufgrund der Signatur nicht anders geht)
        public Task GibFehlerMethodeAsync()
        {
            return Task.Factory.StartNew(() =>
            {
                Thread.Sleep(3000);
                throw new ArithmeticException("Datum falsch berechnet...");
            });
        }

        public Task<string> GibZeitMethodeAsync()
        {
            return Task<string>.Factory.StartNew(() =>
            {
                Thread.Sleep(3000);
                return DateTime.Now.ToLongTimeString();
            });
        }

        public Task MachEtwasAsync()
        {
            CancellationToken token = cts.Token;
            return Task.Run(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    Dispatcher.Invoke(() => progressBarLangsam.Value = i);
                    Thread.Sleep(100);
                    if (token.IsCancellationRequested)
                        break;
                }
                // TaskIstFertigEvent?.Invoke(this, EventArgs.Empty);
            });
        }


        private void MachEtwasSchnell()
        {
            for (int i = 0; i < 100; i++)
            {
                Dispatcher.Invoke(() =>
                {
                    progressBarSchnell.Value = i;
                });
                Thread.Sleep(300);
            }
        }
        private void MachEtwasLangsam()
        {
            for (int i = 0; i < 100; i++)
            {
                Dispatcher.Invoke(() =>
               {
                   progressBarLangsam.Value = i;
               });
                Thread.Sleep(100);
            }
        }


        public int Addieren(int z1, int z2)
        {
            return z1 + z2;
        }
        public int Subtrahieren(int x1, int x2) => x1 + x2;

        private void ButtonAbbruch_Click(object sender, RoutedEventArgs e)
        {
            cts.Cancel();
        }
    }
}
