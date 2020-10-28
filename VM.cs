// Tong Wang
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace JoesFruitDrink
{
    class VM : INotifyPropertyChanged
    {
        const int ONE_FRUIT_PRICE = 3;
        const int TWO_FRUIT_PRICE = 5;
        const int THREE_FRUIT_PRICE = 6;
        public int OneFruit
        {
            get { return oneFruit; }
            set { oneFruit = value; onChange(); }
        }
        private int oneFruit;
        public int TwoFruit
        {
            get { return twoFruit; }
            set { twoFruit = value; onChange(); }
        }
        private int twoFruit;
        public int ThreeFruit
        {
            get { return threeFruit; }
            set { threeFruit = value; onChange(); }
        }
        private int threeFruit;
        public void genInvoice()
        {
            decimal totalOneFruit = oneFruit * ONE_FRUIT_PRICE;
            decimal totalTwoFruit = twoFruit * TWO_FRUIT_PRICE;
            decimal totalThreeFruit = threeFruit * THREE_FRUIT_PRICE;
            decimal total = totalOneFruit + totalTwoFruit + totalThreeFruit;
            decimal tax = total * 0.12m;
            decimal subtotal = total + tax;
            StringBuilder sb = new StringBuilder();
            sb.Append($"Joe's Fruit Drinks Invoice\n");
            string path = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (sfd.ShowDialog() ?? false)
                path = sfd.FileName;
            sb.Append($"{oneFruit} cups One Fruit Drink X $3.00 \t \t \t{totalOneFruit.ToString("c").PadLeft(30)}\n");
            sb.Append($"{twoFruit} cups Two Fruits Drink X $5.00 \t \t {totalTwoFruit.ToString("c").PadLeft(30)}\n");
            sb.Append($"{threeFruit} cups One Fruits Drink X $6.00 \t \t {totalThreeFruit.ToString("c").PadLeft(30)}\n");
            sb.Append($"Tax: \t \t {tax.ToString("c")}\n".PadLeft(70));
            sb.Append($"Subtotal: \t \t {subtotal.ToString("c")}\n".PadLeft(70));
            File.WriteAllText(path, $"{sb}\n");
        }
        #region PropChange
        public event PropertyChangedEventHandler PropertyChanged;

        private void onChange([CallerMemberName] string property = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        #endregion
    }


}
