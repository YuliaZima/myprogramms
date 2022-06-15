void Distance3D ( int Ax, int Ay, int Az, int Bx, int By, int Bz )
{
    double AB = Math.Sqrt((Math.Pow((Bx-Ax),2))+(Math.Pow((By-Ay),2))+(Math.Pow((Bz-Az),2)));
    Console.WriteLine(AB);
}

Distance3D (4, 10, 18, 1, -1, -6);
