package com.example.vuminhhieu.currencyconvert;

import android.support.annotation.NonNull;
import android.support.annotation.Nullable;
import android.util.Log;
import android.widget.Toast;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;

import org.w3c.dom.NodeList;
import org.w3c.dom.Node;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.xml.sax.InputSource;
import org.xml.sax.SAXException;
import org.xml.sax.XMLReader;
import org.xml.sax.helpers.XMLReaderFactory;

import java.net.MalformedURLException;
import java.net.URL;
import java.net.URLConnection;
import java.util.Collection;
import java.util.HashMap;
import java.util.Map;
import java.util.Set;

/**
 * Created by Vu Minh Hieu on 4/14/2018.
 */

public class XmlHanlder {
    private Document m_document;
    private boolean m_isConnected = false;
    private   Map<String, Currency> m_lCurrency;

    public XmlHanlder(String _link){
        m_lCurrency = new HashMap<>();
        ConnectURL(_link);
    }

    public void ConnectURL(final String _link){
        Thread thread = new Thread(new Runnable() {
            @Override
            public void run() {
                try  {
                    URL url = new URL(_link);
                    URLConnection conn = url.openConnection();

                    DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();
                    DocumentBuilder builder = factory.newDocumentBuilder();
                    m_document = builder.parse(conn.getInputStream());
                    Element root= m_document.getDocumentElement();
                    NodeList listNode= root.getElementsByTagName("Exrate");

                    for(int i=0;i  <listNode.getLength();i++)
                    {
                        Node node = listNode.item(i);
                        //data = node.getTextContent();

                        if(node instanceof Element)
                        {
                            Element currency=(Element) node;

                            String sCurrencyCode = currency.getAttribute("CurrencyCode");
                            String sCurrencyName = currency.getAttribute("CurrencyName");

                            Double dBuy = Double.parseDouble(currency.getAttribute("Buy"));
                            Double dTransfer = Double.parseDouble(currency.getAttribute("Transfer"));
                            Double dSell = Double.parseDouble(currency.getAttribute("Sell"));

                            Currency cur = new Currency(sCurrencyCode, sCurrencyName, dBuy, dTransfer, dSell);
                            m_lCurrency.put(sCurrencyCode, cur);
                        }
                    }
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });

        thread.start();
    }

    public Map<String, Currency> GetDataCurrency(){
        return m_lCurrency;
    }

    public boolean IsConnect(){
        return m_isConnected;
    }

}
