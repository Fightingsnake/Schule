Program DAHRS_Rechner;
Uses crt;
Type
  FischArray = Array[0..5] Of Integer;
  FarmArray = Array[0..4] Of Integer;
  integerArray = Array [0..4] Of Integer;

Const
  PreisZiege: Integer = 500;
  PreisSchaf: Integer = 650;
  PreisKleineZiege: Integer = 50;
Var
  i, PreisKuh : Integer;
  DorschP : Integer = 8;
  Dorsch, Aal, Rochen, Hering, Sprotte : Integer;
  Eingabe: Integer = 0;
  antwort : String;
Function ArrayAngebenFarm : farmArray;
Var
  eingabe : Integer;
  farme: farmarray;
Begin
  Writeln('Geben Sie die Anzahl an Tieren ein...');
  For i := 0 To 4 Do
    Case i Of
      0:
         Begin
           Write('Kuehe');
           Readln(eingabe);
           farme[i] := eingabe;
         End;
      1:
         Begin
           Write('Schafe');
           Readln(eingabe);
           farme[i] := eingabe;
         End;
      2:
         Begin
           Write('Ziegen');
           Readln(eingabe);
           farme[i] := eingabe;
         End;
      3:
         Begin
           Write('Wechselziegen');
           Readln(eingabe);
           farme[i] := eingabe;
         End;
      4:
         farme[i] := 0;
    End;
  ArrayAngebenFarm := farme;
End;

Function ArrayAngebenFisch : fischArray;
Var
  eingabe : Integer;
  fische: fischarray;
Begin
  Writeln('Geben Sie die Anzahl an Tieren ein...');
  For i := 0 To 5 Do
    Case i Of
      0:
         Begin
           Write('dorsche');
           Readln(eingabe);
           fische[i] := eingabe;
         End;
      1:
         Begin
           Write('rochen');
           Readln(eingabe);
           fische[i] := eingabe;
         End;
      2:
         Begin
           Write('aal');
           Readln(eingabe);
           fische[i] := eingabe;
         End;
      3:
         Begin
           Write('hering');
           Readln(eingabe);
           fische[i] := eingabe;
         End;
      4:
         Begin
           Write('sprotte');
           Readln(eingabe);
           fische[i] := eingabe;
         End;
      5:
         fische[i] := 0;
    End;
  ArrayAngebenFisch := fische;
End;

Function AnToEu(arr : FarmArray) : Integer;
Var
  j, betrag : Integer;
Begin
  betrag := 0;
  For j := 0 To 4 Do
    Case j Of
      0:
         betrag := arr[j]*PreisKuh;
      1:
         betrag := betrag + arr[j]*PreisSchaf;
      2:
         betrag := betrag + arr[j]*PreisZiege;
      3:
         betrag := betrag + arr[j]*PreisKleineZiege;
      4:
         betrag := betrag + arr[j];
    End;
  AnToEu := betrag;
End;
Function FiToEu(arr : fischarray) : Integer;
Var
  l, betrag : Integer;
Begin
  betrag := 0;
  For l := 0 To 5 Do
    Case l Of
      0:
         betrag := arr[l]*(Dorsch Div 10000);
      1:
         betrag := betrag + arr[l]*(rochen Div 10000);
      2:
         betrag := betrag + arr[l]*(aal Div 10000);
      3:
         betrag := betrag + arr[l]*(hering Div 10000);
      4:
         betrag := betrag + arr[l]*(sprotte Div 10000);
      5:
         betrag := betrag + arr[l];
    End;
  FiToEu := betrag;
End;
Function EuToAn(betrag : Integer) : FarmArray;
Var
  ergebnisArray : FarmArray;
  Restbetrag: Integer;
Begin
  Randomize;
  Writeln('Warten Sie einen Moment... Die Berechnung laeuft...');
  Delay(Random(6837));
  // Verabeitung
  Restbetrag := betrag;
  // Trick
  ergebnisArray[0] := Restbetrag Div PreisKuh;
  // anzahl kuehe
  Restbetrag := Restbetrag Mod Preiskuh;
  ergebnisArray[1] := Restbetrag Div PreisSchaf;
  // anzahl schafe
  Restbetrag := Restbetrag Mod PreisSchaf;
  ergebnisArray[2] := Restbetrag Div PreisZiege;
  // anzahl ziegen
  Restbetrag := Restbetrag Mod PreisZiege;
  ergebnisArray[3] := Restbetrag Div PreisKleineZiege;
  // anzahl wechselziegen
  ergebnisArray[4] := Restbetrag Mod PreisKleineZiege;
  EuToAn := ergebnisArray; {Return ErgebnisArray}
End;

Function EuToFi(betrag : Integer) : fischarray;
Var
  ergebnisarray : fischarray;
  restbetrag : Integer;
Begin
  Randomize;
  Writeln('Warten Sie einen Moment... Die Berechnung laeuft...');
  Delay(Random(6837));
  // Verabeitung
  Restbetrag := betrag * 10000;
  // Trick
  ergebnisarray[0] := restbetrag Div dorsch;
  // anzahl dorsche
  restbetrag := restbetrag Mod dorsch;
  ergebnisarray[1] := restbetrag Div rochen;
  // anzahl rochen
  restbetrag := restbetrag Mod rochen;
  ergebnisarray[2] := restbetrag Div aal;
  // anzahl aale
  restbetrag := restbetrag Mod aal;
  ergebnisarray[3] := restbetrag Div hering;
  // anzahl heringe
  restbetrag := restbetrag Mod hering;
  ergebnisarray[4] := restbetrag Div sprotte;
  // anzahl sprotten
  ergebnisarray[5] := (restbetrag Mod sprotte) Div 10000;
  EuToFi := ergebnisarray;
End;
Procedure AusgabeFarm(arr : FarmArray);
Begin
  For i := 0 To 4 Do
    Case i Of
      0:
         Writeln(arr[i],' Kuehe');
      1:
         Writeln(arr[i],' Schafe');
      2:
         Writeln(arr[i],' Ziegen');
      3:
         Writeln(arr[i],' Wechselziegen');
      4:
         Writeln(arr[i],' Rest');
    End;
End;

Procedure AusgabeFisch(arr : fischarray);
Begin
  For i := 0 To 5 Do
    Case i Of
      0:
         Writeln(arr[i],' dorsche');
      1:
         Writeln(arr[i],' rochen');
      2:
         Writeln(arr[i],' aale');
      3:
         Writeln(arr[i],' heringe');
      4:
         Writeln(arr[i],' sprotten');
      5:
         Writeln(arr[i],' rest');
    End;
End;
Begin
  PreisKuh := 2*PreisSchaf + 3*PreisZiege;
  Dorsch := DorschP * 10000;
  Aal := Dorsch Div 11;
  Hering := Aal Div 5;
  Rochen := 9*Hering + 7*Aal;
  Sprotte := Hering Div 11;
  Repeat
		ClrScr;
    Writeln('Was moechten Sie tun?');
    Writeln('(gu) Geld eintauschen / (fu) Fische eintauschen / (au) Tiere eintauschen / (q) beenden'
    );
    Write('--> ');
    Readln(antwort);
    If antwort = 'fu' Then // fisch to euro
      Writeln(FiToEu(ArrayAngebenFisch))
    Else If antwort = 'au' Then // animal to euro
           Writeln(AnToEu(ArrayAngebenFarm))
    Else If antwort = 'gu' Then // geld umtauschen
           Begin
             Writeln('welche wahl? ( (f) Fisch / (a) Tiere )');
             Readln(antwort);
             If antwort = 'f' Then
               Begin
                 Writeln('Wie viel Geld moechten Sie umtauschen?');
                 Write('--> ');
                 Readln(eingabe);
                 ausgabefisch(eutofi(eingabe));
               End
             Else If antwort = 'a' Then
                    Begin
                      Writeln('Wie viel Geld moechten Sie umtauschen?');
                      Write('--> ');
                      Readln(eingabe);
                      ausgabefarm(eutoan(eingabe));
                    End;
           End
    Else If antwort = 'q' Then // quit
           Begin
             Randomize;
             Writeln('Bis demnaechst');
             Delay(Random(4000));
             break;
           End;
  Until antwort = 'q';
End.
