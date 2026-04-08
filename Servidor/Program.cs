/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 2 - Programaci�n Avanzada | AutoMarket
 * Descripci�n: Programa de gesti�n de ventas de veh�culos
 * Estudiante: Jose David Canizales Azocar
 * Fecha: Abril 2026
 */

using Servidor;

namespace Servidor
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmServidor());
        }
    }
}