package xyz.shubhamkumar.numbersgenerator;

/**
 * Created by Shubham on 17-Mar-18.
 */

public class Caller2 extends Thread {
    private SoapCall cs;
    private int low, high;
    private String operationname, soapAddress;
    public Caller2(String operationname, String soapAddress, int low, int high) {
        this.soapAddress =soapAddress;
        this.operationname = operationname;
        this.low = low;
        this.high = high;
    }

    public void run(){
        try{
            cs=new SoapCall(soapAddress);
            String resp=cs.Call2(operationname, low, high);
            MainActivity.rslt=resp;
        }catch(Exception ex)
        {MainActivity.rslt=ex.toString();}
    }
}