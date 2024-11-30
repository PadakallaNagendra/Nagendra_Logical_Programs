using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Nagendra_Logical_Programs
{
    public class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1 Palindrom"   +"\n"+"2 patrren"  +"\n"+"3 Prime Number"+"  \n"+
             "4 Febonic series"+"\n"+"5 factorial"+"\n"+"6 revers string"+"\n"+
             "7 Biggest Number in ana array"+"\n"+"8 selection sort and bubble sort"+"\n"+"9 recursion"+"\n"+
             "10 Sumof digits"+"\n"+"11 decimal to conversion"+"\n"+"12 Binary to decimal"+"\n"+
             "13 Swap Two Numbers"+"\n"+"14 multipication Table"+"\n"+" 15 AreaofCircle" + "\n" +
             "16 EvenorOdd"+"\n"+"17  Perfect Number"+"\n"+"18 sum of first N Natural Number"
             +"\n"+"19 caluclate the area of a square"+"\n"+"20 find the repeted value"
             +"\n"+"21 caluclate the are circle"+"\n"+"22 caluclate the rectangle"+"\n"+"23 tringle"
             + "\n" + "24 string palindrom" + "\n" + "25 print_Alphabet_Triangle" + "\n" + "26 print_Number_Triangle"
             +"\n"+"27 print star Tringle" + "\n" + "28 print_Diamond_Shape" + "\n" + "29 change_case_of_a_string"
             +"\n" + " 30 add_and_subtract_days_from_the_date" + "\n" + " 31 leap year"
             + "\n" + " 32 compare tow dates" + "\n" + " 33 convert into days weeks years"
             + "\n" + " 34 concate two strings" + "\n" + " 35 vowel or not"


                     );
                Console.WriteLine(     "choose the required field");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                       Palindrom pp=new Palindrom();
                        pp.m1();
                        break;

                    case 2:
                       // Please read the caption first
                        //Here Based On the Value I can write the Condition Please read Properlley
                        // check the condition first
                        Pattrens pn = new Pattrens();
                        Console.WriteLine("enter the Number");
                        n = Convert.ToInt32(Console.ReadLine());
                        if (n <= 5 && n != 0)
                        {
                            pn.m2();
                        }
                        else if (n >= 6)
                        {
                            pn.m3();
                        }
                        else
                        {
                            pn.m4();
                        }
                        //pn.m2();
                        //pn.m3();
                        //pn.m4();


                        break;
                    case 3:
                        SinglePrimeNumber pm = new SinglePrimeNumber();
                        pm.m5();
                        break;
                    case 4:
                       FebonicSeries fs = new FebonicSeries();
                        fs.m6();
                        break;
                    case 5:
                       
                        factorial fr=new factorial();
                        fr.m7();
                        break;
                    case 6:
                        ReversString rs = new ReversString();
                        rs.m8();
                        break;
                    case 7:
                        LargeNumberinArray la = new LargeNumberinArray();
                        la.m9();
                        break;
                    case 8:
                       AssendingDesendingOrder ad=new AssendingDesendingOrder();
                        ad.m10();
                        break;
                    case 9:
                        Recursion rn = new Recursion();
                        rn.m11(1, 10);

                        break;

                    case 10:
                        SumOFDigits sd = new SumOFDigits();
                        sd.m12();

                        break;
                    case 11:
                        DecimalToBinaryConversion dc = new DecimalToBinaryConversion();
                        dc.m13();

                        break;
                    case 12:
                        BinaryToDecimalConversion bd = new BinaryToDecimalConversion();
                        bd.m14();

                        break;
                    case 13:
                        SwapTwoNumbers st = new SwapTwoNumbers();
                        st.m15();

                        break;
                    case 14:
                        multipicationTable m = new multipicationTable();
                        m.m16();

                        break;
                    case 15:
                        AreaofCercle a = new AreaofCercle();
                        a.m17();

                        break;
                    case 16:
                        FindTheEvenOrOdd f = new FindTheEvenOrOdd();
                        f.m18();

                        break;
                    case 17:
                        PerfectNumber p = new PerfectNumber();
                        p.m19();

                        break;
                    case 18:
                        SumOfFirst_N__Natural_Numbers sf = new SumOfFirst_N__Natural_Numbers();
                        sf.m20();

                        break;
                    case 19:
                        Calculate_the_Area_of_a_Square ac = new Calculate_the_Area_of_a_Square();
                        ac.m21();

                        break;
                    case 20:
                        Find_The_Repeted_Value frpv = new Find_The_Repeted_Value();
                        frpv.m23();

                        break;
                    case 21:
                        Calculate_the_Area_of_a_Circle cac = new Calculate_the_Area_of_a_Circle();
                        cac.m24();

                        break;
                    case 22:
                        Calculate_the_Area_of_a_Rectangle car = new Calculate_the_Area_of_a_Rectangle();
                        car.m25();
                        break;
                    case 23:
                        Calculate_the_Area_of_a_Triangle cat = new Calculate_the_Area_of_a_Triangle();
                        cat.m26();
                        break;
                    case 24:
                        Check_Whether_a_String_is_Palindrome_or_Not palin = new Check_Whether_a_String_is_Palindrome_or_Not();
                        palin.m27();
                        break;
                    case 25:
                        print_Alphabet_Triangle pat = new print_Alphabet_Triangle();
                        pat.m28();
                        break;
                    case 26:
                        print_Number_Triangle pnt = new print_Number_Triangle();
                        pnt.m29();
                        break;
                    case 27:
                        print_Star__Triangle pst = new print_Star__Triangle();
                        pst.m30();
                        break;
                    case 28:
                        print_Diamond_Shape pds = new print_Diamond_Shape();
                        pds.m31();
                        break;
                    case 29:
                        change_case_of_a_string ccs = new change_case_of_a_string();
                        ccs.m32();
                        break;
                    case 30:
                        add_and_subtract_days_from_the_date asd = new add_and_subtract_days_from_the_date();
                        asd.m33();
                        break;
                    case 31:
                        Check_Leap_Year ly = new Check_Leap_Year();
                        ly.m34();
                        break;
                    case 32:
                        compare_two_dates ctd = new compare_two_dates();
                        ctd.m35();
                        break;
                    case 33:
                        Convert_days_into_years__weeks_and_days cdy = new Convert_days_into_years__weeks_and_days();
                        cdy.m36();
                        break;
                    case 34:
                        concatenate_two_strings cts = new concatenate_two_strings();
                        cts.m37();
                        break;
                    case 35:
                        CheckWheaterVowelOrNot cwv = new CheckWheaterVowelOrNot();
                        cwv.m38();
                        break;



                        

                    default:
                        Console.WriteLine("Please enter the correct option\n");
                        break;
                }
            }
        }
    }
    
}
