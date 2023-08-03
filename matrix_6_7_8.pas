Program matrix_6_7_8;
Uses crt;
Type
  Matrix = Array[0..9] Of Array[0..9] Of Integer;
Var
  matrix_1 : matrix;
  matrix_2 : matrix;
	matrix_3 : matrix;
  ZuSchreibendeZahl : Integer = 8;
	mathe : char;
	antwortTrue : Boolean = false;

Procedure SchreibeZahlInMxNMatrix(zahl : Integer; Var matritze : matrix);
Var
  zeile, spalte : Integer;
Begin
  For zeile := 0 To 9 Do
    Begin
      For spalte := 0 To 9 Do
        Begin
          matritze[zeile][spalte] := zahl;
          matritze[zeile][spalte] := matritze[zeile][spalte];
        End;
    End;
End;

Procedure ZeigeBestimmteMxNMatrix(x : matrix);
Var
  zeile, spalte : Integer;
Begin
  For zeile := 0 To 9 Do
    Begin
      For spalte := 0 To 9 Do
        Begin
          Write(x[zeile][spalte]);
        End;
      Writeln;
    End;
  Writeln;
End;

Function MxNMatrixBerechnung(m_1, m_2, m_3 : matrix; math : char) : matrix;
Var
  zeile, spalte : Integer;
Begin
  For zeile := 0 To 9 Do
    Begin
      For spalte := 0 To 9 Do
        Begin
				if math = '-' then
					 m_3[zeile][spalte] := m_1[zeile][spalte] - m_2[zeile][spalte]
				Else
					m_3[zeile][spalte] := m_1[zeile][spalte] + m_2[zeile][spalte];
        End;
    End;
		MxNMatrixBerechnung := m_3;
End;
{main}
Begin
	Repeat
	WriteLn('welche operation moechten Sie ausfuehren? ( + oder - )');
	write('--> ');
	mathe := ReadKey;
	if (mathe = '-') or (mathe = '+') Then
		antwortTrue := True
	Else
		WriteLn('Falsche Eingabe :(');
	Until antwortTrue = true;
  Writeln('vorher:');
  ZeigeBestimmteMxNMatrix(matrix_1);
  SchreibeZahlInMxNMatrix(ZuSchreibendeZahl,matrix_1);
  SchreibeZahlInMxNMatrix(2,matrix_2);
	matrix_3 := MxNMatrixBerechnung(matrix_1, matrix_2, matrix_3, mathe);
  Writeln('nachher:');
  ZeigeBestimmteMxNMatrix(matrix_1);
  ZeigeBestimmteMxNMatrix(matrix_2);
	ZeigeBestimmteMxNMatrix(matrix_3);
End.
