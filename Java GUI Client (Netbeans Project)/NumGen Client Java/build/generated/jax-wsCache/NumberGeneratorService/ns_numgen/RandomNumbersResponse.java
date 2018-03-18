
package ns_numgen;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Java class for anonymous complex type.
 * 
 * <p>The following schema fragment specifies the expected content contained within this class.
 * 
 * <pre>
 * &lt;complexType>
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="randomNumbersResult" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "randomNumbersResult"
})
@XmlRootElement(name = "randomNumbersResponse")
public class RandomNumbersResponse {

    protected String randomNumbersResult;

    /**
     * Gets the value of the randomNumbersResult property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getRandomNumbersResult() {
        return randomNumbersResult;
    }

    /**
     * Sets the value of the randomNumbersResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setRandomNumbersResult(String value) {
        this.randomNumbersResult = value;
    }

}
