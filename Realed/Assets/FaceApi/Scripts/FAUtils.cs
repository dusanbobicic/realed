using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FAUtils {

	public static double getConfidenceForCompare(byte[] image)
    {
       // string fp0 = "C:\\Users\\bobic\\Desktop\\SLIKE\\img00.jpg";
        ///string fp1 = "C:\\Users\\bobic\\Desktop\\SLIKE\\img01.jpg";
       // byte[] imgD0 = File.ReadAllBytes(fp0);
        //byte[] imgD1 = File.ReadAllBytes(fp1);
        FARequest frf = new FARequest(APIConstants.APIKEY, APIConstants.APISECRET);
        frf.image_file1 = image;
        frf.image_file2 = ;

        var obj = GameObject.Find("HttpUtil");
        HTTPUtils htp = obj.GetComponent<HTTPUtils>();
        htp.POST(APIConstants.APIURL_COMPARE, frf);
        while (!htp) { }
        double data = htp.confData;
        return data;
    }
}
