// Java

public class TimeFormatter {
  public static String formatDuration(int seconds) {
    if(seconds == 0)
      return "now";
    
    int[] date= {seconds / (60*60*24*365),
           seconds % (60*60*24*365) / (60*60*24),
           seconds % (60*60*24) / (60*60),
           seconds % (60*60) / 60,
           seconds % 60};
    
    String str = "";
    
    for(int i = 0; i < 5; i++) {
      
      String currentChrono = i == 0 ? "year" :
                   i == 1 ? "day" :
                   i == 2 ? "hour" : 
                   i == 3 ? "minute" : 
                   i == 4 ? "second" : "";
      
      if(date[i] > 0) {
        str += date[i] + " " + currentChrono + (date[i] > 1 ? "s" : "");
        
        if((i == 2 && (date[i+1] != 0 && date[i+2] != 0))||
           (i == 1 && ((date[i+1] != 0 && date[i+2] != 0)||(date[i+1] != 0 && date[i+3] != 0)||(date[i+2] != 0 && date[i+3] != 0)))||
           (i == 0 && ((date[i+1] != 0 && date[i+2] != 0)||(date[i+1] != 0 && date[i+3] != 0)||(date[i+1] != 0 && date[i+4] != 0)||(date[i+2] != 0 && date[i+3] != 0)||(date[i+2] != 0 && date[i+4] != 0)||(date[i+3] != 0 && date[i+4] != 0))))
            str += ", ";

        if((i == 3 && date[i+1] != 0)||
           (i == 2 && ((date[i+1] == 0 && date[i+2] != 0)||(date[i+1] != 0 && date[i+2] == 0)))||
           (i == 1 && ((date[i+1] != 0 && date[i+2] == 0 && date[i+3] == 0)||(date[i+1] == 0 && date[i+2] != 0 && date[i+3] == 0)||(date[i+1] == 0 && date[i+2] == 0 && date[i+3] != 0)))||
           (i == 0 && ((date[i+1] != 0 && date[i+2] == 0 && date[i+3] == 0 && date[i+4] == 0)||(date[i+1] == 0 && date[i+2] != 0 && date[i+3] == 0 && date[i+4] == 0)||(date[i+1] == 0 && date[i+2] == 0 && date[i+3] != 0 && date[i+4] == 0)||(date[i+1] == 0 && date[i+2] == 0 && date[i+3] == 0 && date[i+4] != 0))))
            str += " and ";
      }    
    }
    
    return str;
  }
}
