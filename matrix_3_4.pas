Program matrix_3_4;
Uses crt;
Type
  Matrix = Array[0..9] Of Array[0..9] Of Integer;
Var
  x : matrix;
Procedure MxNMatrixInitialisieren;
Var
  zeile, spalte : Integer;
Begin
  For zeile := 0 To 9 Do
    Begin
      For spalte := 0 To 9 Do
        Begin
          x[zeile][spalte] := zeile;
        End;
    End;
End;

Function MxNMatrixMultiplizieren( arr : matrix) : matrix;
Var
  zeile, spalte : Integer;
  multipliziereMit : Integer;
Begin
  multipliziereMit := 10;
  For zeile := 0 To 9 Do
    Begin
      For spalte := 0 To 9 Do
        Begin
          arr[zeile][spalte] := arr[zeile][spalte] * multipliziereMit;
        End;
    End;
  MxNMatrixMultiplizieren := arr;
End;

Procedure MxNMatrixAusgeben( arr : matrix);
Var
  zeile, spalte : Integer;
Begin
  For zeile := 0 To 9 Do
    Begin
      For spalte := 0 To 9 Do
        Begin
          Write(arr[zeile][spalte]);
        End;
      Writeln;
    End;
		WriteLn;
End;

Begin
  MxNMatrixInitialisieren;
  MxNMatrixAusgeben(x);
  x := MxNMatrixMultiplizieren(x);
  MxNMatrixAusgeben(x);
End.