Racistgame dokument 

 

Så här kan du göra ett lopp spel i unity 

Först skall kan man göra sina sprites t.ex. bakgrunden och bilen etc.. 

Sen gör man movement koden som behöver “Getkey” för att hitta olika bokstäver på ditt tangentbord så att man kan göra playern att fara frammåt. (du kan ha samma kåd för 2 olika “players” men med olika bokstäver i “Getkey”) 

Man skall också ha under alla Getkeys en turndirection som skall vara t.ex. 1.0f; 

Gör en object som heter t.ex. boundary, som skall inte låta spälaren fara utanför spelgrunderna/mappen, sätt också boundary runt banan som spelas på. 

Man göra samma med finishline med att ha en boxcollider2d men man har “is trigger” på. 

För att få finishline att räkna poäng skall man ha en collider2d i koden som har en “if” på båda spelarna. 

GameManager skall ha de poäng man behöver för att vinna, också skall man ha en “onEnable” och “onDisable” för finishline så att spelarna aktiverar nästa delen av koden som är debug log. 

I debug log kan man sätta vad somhelst som text för att man har vunnit t.ex. you won, gg, pakistan. 

Här är en racegame som exempel: https://github.com/joebidensoda/cargame 
