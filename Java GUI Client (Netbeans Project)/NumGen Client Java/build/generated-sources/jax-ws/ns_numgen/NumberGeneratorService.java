
package ns_numgen;

import java.net.MalformedURLException;
import java.net.URL;
import javax.xml.namespace.QName;
import javax.xml.ws.Service;
import javax.xml.ws.WebEndpoint;
import javax.xml.ws.WebServiceClient;
import javax.xml.ws.WebServiceException;
import javax.xml.ws.WebServiceFeature;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.6-1b01 
 * Generated source version: 2.2
 * 
 */
@WebServiceClient(name = "NumberGeneratorService", targetNamespace = "NS_NumGen", wsdlLocation = "http://shubham.somee.com/app/NumberGeneratorService.asmx?WSDL")
public class NumberGeneratorService
    extends Service
{

    private final static URL NUMBERGENERATORSERVICE_WSDL_LOCATION;
    private final static WebServiceException NUMBERGENERATORSERVICE_EXCEPTION;
    private final static QName NUMBERGENERATORSERVICE_QNAME = new QName("NS_NumGen", "NumberGeneratorService");

    static {
        URL url = null;
        WebServiceException e = null;
        try {
            url = new URL("http://shubham.somee.com/app/NumberGeneratorService.asmx?WSDL");
        } catch (MalformedURLException ex) {
            e = new WebServiceException(ex);
        }
        NUMBERGENERATORSERVICE_WSDL_LOCATION = url;
        NUMBERGENERATORSERVICE_EXCEPTION = e;
    }

    public NumberGeneratorService() {
        super(__getWsdlLocation(), NUMBERGENERATORSERVICE_QNAME);
    }

    public NumberGeneratorService(WebServiceFeature... features) {
        super(__getWsdlLocation(), NUMBERGENERATORSERVICE_QNAME, features);
    }

    public NumberGeneratorService(URL wsdlLocation) {
        super(wsdlLocation, NUMBERGENERATORSERVICE_QNAME);
    }

    public NumberGeneratorService(URL wsdlLocation, WebServiceFeature... features) {
        super(wsdlLocation, NUMBERGENERATORSERVICE_QNAME, features);
    }

    public NumberGeneratorService(URL wsdlLocation, QName serviceName) {
        super(wsdlLocation, serviceName);
    }

    public NumberGeneratorService(URL wsdlLocation, QName serviceName, WebServiceFeature... features) {
        super(wsdlLocation, serviceName, features);
    }

    /**
     * 
     * @return
     *     returns NumberGeneratorServiceSoap
     */
    @WebEndpoint(name = "NumberGeneratorServiceSoap")
    public NumberGeneratorServiceSoap getNumberGeneratorServiceSoap() {
        return super.getPort(new QName("NS_NumGen", "NumberGeneratorServiceSoap"), NumberGeneratorServiceSoap.class);
    }

    /**
     * 
     * @param features
     *     A list of {@link javax.xml.ws.WebServiceFeature} to configure on the proxy.  Supported features not in the <code>features</code> parameter will have their default values.
     * @return
     *     returns NumberGeneratorServiceSoap
     */
    @WebEndpoint(name = "NumberGeneratorServiceSoap")
    public NumberGeneratorServiceSoap getNumberGeneratorServiceSoap(WebServiceFeature... features) {
        return super.getPort(new QName("NS_NumGen", "NumberGeneratorServiceSoap"), NumberGeneratorServiceSoap.class, features);
    }

    /**
     * 
     * @return
     *     returns NumberGeneratorServiceSoap
     */
    @WebEndpoint(name = "NumberGeneratorServiceSoap12")
    public NumberGeneratorServiceSoap getNumberGeneratorServiceSoap12() {
        return super.getPort(new QName("NS_NumGen", "NumberGeneratorServiceSoap12"), NumberGeneratorServiceSoap.class);
    }

    /**
     * 
     * @param features
     *     A list of {@link javax.xml.ws.WebServiceFeature} to configure on the proxy.  Supported features not in the <code>features</code> parameter will have their default values.
     * @return
     *     returns NumberGeneratorServiceSoap
     */
    @WebEndpoint(name = "NumberGeneratorServiceSoap12")
    public NumberGeneratorServiceSoap getNumberGeneratorServiceSoap12(WebServiceFeature... features) {
        return super.getPort(new QName("NS_NumGen", "NumberGeneratorServiceSoap12"), NumberGeneratorServiceSoap.class, features);
    }

    private static URL __getWsdlLocation() {
        if (NUMBERGENERATORSERVICE_EXCEPTION!= null) {
            throw NUMBERGENERATORSERVICE_EXCEPTION;
        }
        return NUMBERGENERATORSERVICE_WSDL_LOCATION;
    }

}