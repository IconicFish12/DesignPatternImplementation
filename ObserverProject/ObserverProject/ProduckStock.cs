using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverProject
{
    internal class ProductStock : ISubject
    {
        private List<IObserver> _observers = new();
        private string _productName;
        private int _stock;

        public ProductStock(string productName, int stock)
        {
            _productName = productName;
            _stock = stock;
        }

        public void Attach(IObserver observer) => _observers.Add(observer);
        public void Detach(IObserver observer) => _observers.Remove(observer);

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_productName, _stock);
            }
        }

        public void SetStock(int newStock)
        {
            _stock = newStock;
            Console.WriteLine($"\n[INFO] Stock updated for {_productName}: {_stock}");
            Notify();
        }
    }
}
