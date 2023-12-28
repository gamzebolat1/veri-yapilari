using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekYonluDogrusalListe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            listemiz tydl = new listemiz();
            int secim = menu();
            int sayi;
            while(secim != 0)
            {
                switch (secim)
                {
                    case 1:
                        Console.WriteLine("sayi: ");
                        sayi = int.Parse(Console.ReadLine());
                        tydl.basaEkle(sayi);
                        break;

                    case 2:
                        Console.WriteLine("sayi: ");
                        sayi = int.Parse(Console.ReadLine());
                        tydl.sonaEkle(sayi);
                        break;

                    case 3:
                        tydl.bastanSil();
                        break;

                    case 4:
                        tydl.sondanSil();
                        break;


                    case 0: break;
                    default:
                        Console.WriteLine("hatalı seçim yaptınız");
                        break;
                }
                Console.Clear();
                tydl.yazdir();
                secim = menu();
            }
        }

        private static int menu()
        {
            int secim;
            Console.WriteLine("1-başa ekle");
            Console.WriteLine("2-sona ekle");
            Console.WriteLine("3-baştan sil");
            Console.WriteLine("4-sondan sil");
            Console.WriteLine("0-programı kapat");
            Console.WriteLine("seciminiz: ");
            secim = int.Parse(Console.ReadLine());
            return secim;
        }

        class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
                next = null;
            }
        }


        class listemiz
        {
            Node head;
            public listemiz() 
            {
                head = null;
            }

            public void basaEkle(int data)
            {
                Node eleman= new Node(data);
                if (head == null) 
                {
                    head = eleman;
                    Console.WriteLine("liste oluşturuldu ilk eleman eklendi");
                }
                else
                {
                    eleman.next= head;
                    head = eleman;
                    Console.WriteLine("başa eleman eklendi");
                }
            }
            public void sonaEkle(int data) 
            { 
                Node eleman= new Node(data);
                if(head == null)
                {
                    head= eleman;
                }
                else
                {
                    Node temp= head;
                    while (temp.next != null)
                    {
                        temp= temp.next;
                    }
                    temp.next = eleman;
                }
            }

            public void bastanSil()
            {
                if(head == null)
                {
                    Console.WriteLine("liste boş");
                }
                else if(head.next==null)
                {
                    head = null;
                    Console.WriteLine("kalan son elemanı da sildiniz");
                }
                else
                {
                    head=head.next;
                    Console.WriteLine("baştan eleman silindi");
                }
            }


            public void sondanSil()
            {
                if (head == null)
                {
                    Console.WriteLine("liste boş");
                }
                else if (head.next == null)
                {
                    head = null;
                    Console.WriteLine("kalan son elemanı da sildiniz");
                }
                else
                {
                    Node temp= head;
                    Node temp2 = temp;
                    while (temp.next != null)
                    {
                        temp2 = temp;
                        temp = temp.next;
                    }
                    temp2.next = null;
                    Console.WriteLine("sondan eleman silindi");
                }
            }

            public void yazdir()
            {
                if(head==null)
                    Console.WriteLine("liste boş");
                else
                {
                    Node temp = head;
                    while(temp.next != null)
                    {
                        Console.Write(temp.data + " -> ");
                        temp = temp.next;
                    }
                    Console.WriteLine(temp.data);
                }
            }

           










        }


    }
}
