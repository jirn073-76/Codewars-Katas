// FSharp

let fitByteRange (num:int) =
        if num < 0 then 0
        elif num > 255 then 255
        else num
        
let rgb (r:int) (g:int) (b:int) = 
       let byteToHex dec = 
           let hexChars = "0" :: "1":: "2":: "3":: "4":: "5":: "6":: "7":: "8":: "9":: "A":: "B":: "C":: "D":: "E":: "F" :: []
           hexChars.[dec / 16] + hexChars.[dec % 16]  
       byteToHex (fitByteRange r) + byteToHex (fitByteRange g) + byteToHex (fitByteRange b)   
