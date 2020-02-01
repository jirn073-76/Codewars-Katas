// FSharp

let alph = ['A';'B';'C';'D';'E';'F';'G';'H';'I';'J';'K';'L';'M';'N';'O';'P';'Q';'R';'S';'T';'U';'V';'W';'X';'Y';'Z';'a';'b';'c';'d';'e';'f';'g';'h';'i';'j';'k';'l';'m';'n';'o';'p';'q';'r';'s';'t';'u';'v';'w';'x';'y';'z';'@';'8';'(';'D';'3';'F';'6';'#';'!';'J';'K';'1';'M';'N';'0';'P';'Q';'R';'$';'7';'U';'V';'W';'X';'Y';'2';]
let find x = List.findIndex(fun y -> y = x) alph
let toLeetSpeak s = String.map(fun x -> if x = ' ' 
                                          then x 
                                        elif (find x < 27) 
                                          then List.item (find x + 52) alph 
                                        else List.item (find x + 26) alph) 
                                        s
  
