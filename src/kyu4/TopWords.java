import java.util.List;
import java.util.Map.Entry;
import java.util.Arrays;
import java.util.Comparator;
import java.util.HashMap;
import java.util.ArrayList;

public class TopWords {

    public static List<String> top3(String s) {
       System.out.println(s);
       HashMap<String, Integer> dict = new HashMap<String, Integer>();
       String[] listOfWords = s.split("[ ?!/,.;:_-]");

       for(String vote: listOfWords) {
           vote = vote.toLowerCase();
          vote = vote.replaceAll("[^a-zA-Z']", "");

          if(vote.equals("") || vote.charAt(0) == '\'')
            continue;

         if(dict.containsKey(vote)) 
           dict.put(vote, dict.get(vote)+1);
         else 
           dict.put(vote, 1);
       }

       Entry<String, Integer>[] sortedDict = new Entry[dict.size()];
       int i = 0;
       for(Entry<String, Integer> obj: dict.entrySet()) 
        sortedDict[i++] = obj;

       Arrays.sort(sortedDict, new Comparator<Entry<String, Integer>>() {
              @Override
              public int compare(Entry<String, Integer> o1, Entry<String, Integer> o2) {
                return o2.getValue().compareTo(o1.getValue());
              }
          });

       ArrayList<String> winners = new ArrayList<String>();

       if(sortedDict.length > 0)
         winners.add(sortedDict[0].getKey());

       if(sortedDict.length > 1)
         winners.add(sortedDict[1].getKey());

       if(sortedDict.length > 2)
         winners.add(sortedDict[2].getKey());

       return winners;
 }
}
