Program matrix_1_2;
Uses crt;
Var
  zeile, spalte, x, i : Integer;
Procedure ZeigeZahlenQuadrat;
Begin
  For zeile := 0 To 9 Do
    Begin
      For spalte := 0 To 9 Do
        Begin
          Write(zeile)
        End;
      Writeln;
    End;
End;
Procedure ZeigeXMalZahlenQuadrat(x : Integer);
Begin
  For i := 0 To x Do
    Begin
		WriteLn(i,':');
      For zeile := 0 To 9 Do
        Begin
          For spalte := 0 To 9 Do
            Begin
              Write(zeile)
            End;
          Writeln;
        End;
      Writeln;
    End;
End;
Begin
  zeigezahlenquadrat;
	WriteLn ('x festlegen');
	write('--> ');
	readln(x);
  ZeigeXMalZahlenQuadrat(x);
End.