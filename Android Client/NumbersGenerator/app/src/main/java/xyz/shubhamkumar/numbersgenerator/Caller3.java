package xyz.shubhamkumar.numbersgenerator;

/**
 * Created by Shubham on 17-Mar-18.
 */

public class Caller3 extends Thread {
    private SoapCall cs;
    private int low, high, n;
    private String operationname, soapAddress;
    public Caller3(String operationname, String soapAddress, int low, int high, int n) {
        this.soapAddress =soapAddress;
        this.operationname = operationname;
        this.low = low;
        this.high = high;
        this.n = n;
    }

    public void run(){
        try{
            cs=new SoapCall(soapAddress);
            String resp=cs.Call3(operationname, low, high, n);
            MainActivity.rslt=resp;
        }catch(Exception ex)
        {MainActivity.rslt=ex.toString();}
    }
}