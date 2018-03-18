package xyz.shubhamkumar.numbersgenerator;

import android.app.Activity;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import android.view.inputmethod.InputMethodManager;

public class MainActivity extends AppCompatActivity {

    public static String rslt = "";
    public static String soapAddrtail = "/app/NumberGeneratorService.asmx";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    private String GetOperationName() {
        Spinner sp = (Spinner) findViewById(R.id.spinner);
        int pos = sp.getSelectedItemPosition();

        switch (pos) {
            case 0 : return "primeRange";
            case 1 : return "compositeRange";
            case 2 : return "perfectSquaresRange";
            case 3 : return "fibonacciRange";
            case 4 : return "powersofTwo";
            case 5 : return "evenRange";
            case 6 : return "oddRange";
            case 7 : return "palindromeRange";
        }
        return "INVALID";
    }

    public void btnGenerateOnClick(View view) {

        try  {
            InputMethodManager inputManager = (InputMethodManager) getSystemService(this.INPUT_METHOD_SERVICE);
            inputManager.hideSoftInputFromWindow(getCurrentFocus().getWindowToken(), InputMethodManager.HIDE_NOT_ALWAYS);
        } catch (Exception e) {

        }

        String operationname = GetOperationName();
        String soapAddr = ((EditText) findViewById(R.id.tburl)).getText().toString() + soapAddrtail;

        try {
            int start = Integer.parseInt(((EditText) findViewById(R.id.tbstart)).getText().toString());
            int end = Integer.parseInt(((EditText) findViewById(R.id.tbEnd)).getText().toString());
            Caller2 c = new Caller2(operationname, soapAddr, start, end);
            c.start();
            c.join();
            ((TextView) findViewById(R.id.tbAnswer)).setText(rslt);
        } catch (Exception ex) {
            ((TextView) findViewById(R.id.tbAnswer)).setText(ex.getMessage());
        }


    }
}
