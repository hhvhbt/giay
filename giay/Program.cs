using Microsoft.Win32.SafeHandles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();

        }
        static void Menu() {
            int chon;
            ArrayList Shoes = new ArrayList();

            do {

                Console.WriteLine("---------------Cua hang ban giay NET101---------------");
                Console.WriteLine("1.Them moi mot doi giay");
                Console.WriteLine("2.Danh sach Giay");
                Console.WriteLine("3.Mua Giay");
                Console.WriteLine("4.Thoat");
                Console.WriteLine("Chon tu 1-4");


                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        break;


                    case 2:
                       
                        break;

                    case 3:

                        break;
                    case 4:

                        break;
                    default: Console.WriteLine("Vui long nhap lai!!");
                        break;

                }
            } while (chon != 4);
        }
        static void
            
        }
    }

