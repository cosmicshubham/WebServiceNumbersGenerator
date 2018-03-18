
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
 *         &lt;element name="powersofTwoResult" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
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
    "powersofTwoResult"
})
@XmlRootElement(name = "powersofTwoResponse")
public class PowersofTwoResponse {

    protected String powersofTwoResult;

    /**
     * Gets the value of the powersofTwoResult property.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getPowersofTwoResult() {
        return powersofTwoResult;
    }

    /**
     * Sets the value of the powersofTwoResult property.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setPowersofTwoResult(String value) {
        this.powersofTwoResult = value;
    }

}
