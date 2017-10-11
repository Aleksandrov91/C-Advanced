package com.company;

import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.time.LocalDate;
import java.util.Date;
import java.util.Scanner;


public class Main {

    public static void main(String[] args) throws ParseException {
        Scanner scan = new Scanner(System.in);

        String firstDate = scan.nextLine();
        String secondDate = scan.nextLine();

        DateFormat formatter = new SimpleDateFormat("dd-MM-yyyy");

        LocalDate startDate = formatter.parse(firstDate);
        LocalDate endDate = formatter.parse(secondDate);

        for (LocalDate currentDate = startDate; currentDate.isBefore(endDate); currentDate = currentDate.plusDays(1)) {

        }

    }
}
