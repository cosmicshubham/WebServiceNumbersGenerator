package xyz.shubhamkumar.numbersgenerator;

/**
 * Created by Shubham on 17-Mar-18.
 */

import org.ksoap2.SoapEnvelope;
import org.ksoap2.serialization.PropertyInfo;
import org.ksoap2.serialization.SoapObject;
import org.ksoap2.serialization.SoapSerializationEnvelope;
import org.ksoap2.transport.HttpTransportSE;

    public class SoapCall {
        public String SOAP_ACTION; // = "http://tempuri.org/counter";

        // public String OPERATION_NAME = "counter";

        public String WSDL_TARGET_NAMESPACE = "NS_NumGen";
        public  String SOAP_ADDRESS;

        public SoapCall(String soapAddr)
        {
            SOAP_ADDRESS = soapAddr;
        }
        public String Call2(String operationName, int start, int end)
        {
            SoapObject request = new SoapObject(WSDL_TARGET_NAMESPACE,operationName);
            PropertyInfo pi=new PropertyInfo();
            pi.setName("low");
            pi.setValue(start);
            pi.setType(Integer.class);
            request.addProperty(pi);
            pi=new PropertyInfo();
            pi.setName("high");
            pi.setValue(end);
            pi.setType(Integer.class);
            request.addProperty(pi);

            SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(
                    SoapEnvelope.VER11);
            envelope.dotNet = true;

            envelope.setOutputSoapObject(request);

            HttpTransportSE httpTransport = new HttpTransportSE(SOAP_ADDRESS);
            Object response=null;
            try
            {
                httpTransport.call(WSDL_TARGET_NAMESPACE + "/" + operationName, envelope);
                response = envelope.getResponse();
            }
            catch (Exception exception)
            {
                response=exception.getMessage();
            }
            return response.toString();
        }

        public String Call3(String operationName, int start, int end, int n)
        {
            SoapObject request = new SoapObject(WSDL_TARGET_NAMESPACE, operationName);
            PropertyInfo pi=new PropertyInfo();
            pi.setName("low");
            pi.setValue(start);
            pi.setType(Integer.class);
            request.addProperty(pi);
            pi=new PropertyInfo();
            pi.setName("high");
            pi.setValue(end);
            pi.setType(Integer.class);
            pi=new PropertyInfo();
            pi.setName("n");
            pi.setValue(n);
            pi.setType(Integer.class);
            request.addProperty(pi);

            SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(
                    SoapEnvelope.VER11);
            envelope.dotNet = true;

            envelope.setOutputSoapObject(request);

            HttpTransportSE httpTransport = new HttpTransportSE(SOAP_ADDRESS);
            Object response=null;
            try
            {
                httpTransport.call(WSDL_TARGET_NAMESPACE + "/" + operationName, envelope);
                response = envelope.getResponse();
            }
            catch (Exception exception)
            {
                response=exception.getMessage();
            }
            return response.toString();
        }


    }
