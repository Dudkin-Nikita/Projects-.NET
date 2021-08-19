﻿// такие значения констант помогут легче вычислить номер клавиши
// и сделают клавишу с номером 0 - корректной
// в каждой октаве - 12 полутонов!

public enum Octave
{
    Sub = -48,
    Contra = -36,
    Great = -24,
    Small = -12,
    First = 0,
    Second = 12,
    Third = 24,
    Fourth = 36,
    Fifth = 48
}