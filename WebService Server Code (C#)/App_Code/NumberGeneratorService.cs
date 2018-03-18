using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for NumberGeneratorService
/// </summary>
[WebService(Namespace = "NS_NumGen")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class NumberGeneratorService:
    System.Web.Services.WebService {
    public NumberGeneratorService() {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }
    private  bool checkPrimeNumber(int num) {
        if (num <= 1 )
            return false;
        bool flag = true;
        for (int i = 2; i <= num / 2; ++i) {

            if (num % i == 0) {
                flag = false;
                break;
            }
        }
        return flag;
    }
    [WebMethod]
    public  string primeRange(int low, int high) {
        ArrayList ar = new ArrayList();
        StringBuilder sb = new StringBuilder("");
        while (low <= high) {
            if (checkPrimeNumber(low)) {
                sb.Append(low);
                sb.Append(Environment.NewLine);
            }
            ++low;
        }
        return sb.ToString();
    }

    //Composite Range
    [WebMethod]
    public  string compositeRange(int low, int high) {
        ArrayList ar = new ArrayList();
        StringBuilder sb = new StringBuilder("");
        while (low <= high) {
            if (!checkPrimeNumber(low)) {
                sb.Append(low);
                sb.Append(Environment.NewLine);
            }
            ++low;
        }
        return sb.ToString();
    }

    //Perfect Square
    [WebMethod]
    public string perfectSquaresRange(int low, int high) {
        StringBuilder sb = new StringBuilder();
        for (int x = low; x <= high; x++) {
            double d = Math.Sqrt(x);
            int d1 = (int)Math.Sqrt(x);
            if (d - d1 > 0)
                continue;
            else {
                sb.Append(x);
                sb.Append(Environment.NewLine);
            }
        }
        return sb.ToString();
    }



    public ArrayList fibonacci(int n) {
        ArrayList ar = new ArrayList();
        int a = 0, b = 1;
        ar.Add(a);
        ar.Add(b);
        int c = a + b;
        while ((c = a + b) <= n) {
            ar.Add(c);
            a = b;
            b = c;
        }

        return ar;
    }
    //Fibonacci numbers
    [WebMethod]
    public string fibonacciRange(int low, int high) {
        ArrayList ar = fibonacci(high);
        StringBuilder sb = new StringBuilder();
        int x = low;
        while (!ar.Contains(x))
            x++;
        int index = ar.IndexOf(x);
        while (index < ar.Count) {
            sb.Append(ar[index] + Environment.NewLine);
            index++;
        }
        //System.out.println(sb);
        return sb.ToString();
    }

    //Random numbers
    [WebMethod]
    public  string randomNumbers(int low, int high, int n) {
        Random rand = new Random();
        StringBuilder sb = new StringBuilder("");
        for (int x = 0; x <= n; x++) {
            int randomNum = rand.Next((high - low) + 1) + low;
            sb.Append(randomNum);
            sb.Append(Environment.NewLine);
        }
        return sb.ToString();
    }

    //Powers of 2
    [WebMethod]
    public string powersofTwo(int low, int high) {
        int[] powof2 = new int[30];
        for (int x = 0; x < powof2.Length; x++) {
            powof2[x] = (int)Math.Pow(2, x);
        }
        StringBuilder sb = new StringBuilder("");
        for (int x = low; x <= high; x++) {
            for (int y = 0; y < 30; y++) {
                if (powof2[y] == x) {
                    sb.Append(x);
                    sb.Append(Environment.NewLine);
                }
            }
        }
        return sb.ToString();
    }

    //Range Even Numbers
    [WebMethod]
    public  string evenRange(int low, int high) {
        StringBuilder sb = new StringBuilder("");
        while (low <= high) {
            if (low % 2 == 0) {
                sb.Append(low);
                sb.Append(Environment.NewLine);
            }
            ++low;
        }
        return sb.ToString();
    }

    //Range Odd Numbers
    [WebMethod]
    public  string oddRange(int low, int high) {
        StringBuilder sb = new StringBuilder("");
        while (low <= high) {
            if (low % 2 != 0) {
                sb.Append(low);
                sb.Append(Environment.NewLine);
            }
            ++low;
        }
        return sb.ToString();
    }

    //Range Palindrome Numbers
    [WebMethod]
    public  string palindromeRange(int low, int high) {
        StringBuilder sb = new StringBuilder("");
        while (low <= high) {
            if (checkPalindromeNumber(low)) { 
                sb.Append(low);
                sb.Append(Environment.NewLine);
            }
            ++low;
        }
        return sb.ToString();

    }

    private  bool checkPalindromeNumber(int n) {

        string num = n.ToString();
        char[] charArray = num.ToCharArray();
        Array.Reverse(charArray);
        string rev = new string(charArray);
        if (num == rev) {
            return true;
        }
        else {
            return false;
        }
     }


}
