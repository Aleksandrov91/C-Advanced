package com.company;

import com.sun.org.apache.xerces.internal.impl.xpath.regex.Match;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String input = scan.nextLine();

        String protocol = "";

        String pattern = "://";
        Pattern reg = Pattern.compile(pattern);
        Matcher prot = reg.matcher(input);

        String data = "";
        if (prot.find()){
            protocol = prot.group(0);
            System.out.print(protocol);
            data = prot.group(2);
            return;
        }

        int dataEnd = data.indexOf("/");
        String server = data.substring(0, dataEnd);
        String resource = data.substring(dataEnd, data.charAt(data.length() - 1));

        System.out.printf("[protocol] = \"%s\"%n", protocol);
        System.out.printf("[server] = \"%s\"%n", server);
        System.out.printf("[resource] = \"%s\"%n", resource);
    }
}
