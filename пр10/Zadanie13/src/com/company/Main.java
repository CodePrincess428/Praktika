package com.company;

public class Main {
    public static double getRandomNumber(double min, double max){
        double x = (int)(Math.random()*((max-min)+1))+min;
        return x;
    }
    public static void main(String[] args) {
	    int [][] arr = new int[10][10];
            for(int x=0;x<arr.length;x++){
                for(int y=0;y<arr.length;y++){
                    arr[x][y]=(int)getRandomNumber(0,99);
                    System.out.print(arr[x][y]+" \t");
                }
                System.out.println();
            }
            System.out.println();
       for(int j=0;j<10;j++){
           for(int i=0;i<9;i++){
               for(int k=i+1;k<10;k++){
                   if(arr[i][j]>arr[k][j]){
                       int temp = (int)arr[i][j];
                       arr[i][j]=arr[k][j];
                       arr[k][j]=temp;
                   }
               }
           }
       }
       for(int x=0;x<arr.length;x++){
            for(int y=0;y<arr.length;y++){
                System.out.print(arr[x][y]+" \t");
            }
            System.out.println();
        }
    }
}
