@echo off
title Exercicio Jogo de Numeros Aleatorios
color 0a

:Sorteio
set /a numero=(%Random% %% 50) + 1
set /a tentativas=5
goto Inicio

:Inicio
cls
echo.
echo -------------------------------------------
echo Adivinhe um numero de 1 a 50: 
echo Quantidade de tentativas: %tentativas%
echo -------------------------------------------
echo.
if %tentativas% == 0 (goto:try)

set /p nusuario=Digite seu numero:

if %nusuario% LSS 1 (goto:invalido)

if %nusuario% GTR 50 (goto:invalido)

if %nusuario% == %numero% (goto:correto)

if %nusuario% GTR %numero% (goto:maior)

if %nusuario% LSS %numero% (goto:menor)




:try
echo.
echo -------------------------------------------
echo Suas tentativas acabaram! O numero era: %numero%
echo -------------------------------------------
set /p resp=Deseja jogar novamente? [S/N]:
if /i %resp% == S (goto:Sorteio) else (exit)

:invalido
echo.    
echo -------------------------------------------
echo Digite um numero de 1 a 50: 
echo -------------------------------------------
pause
goto Inicio

:correto
echo.
echo ---------------------------
echo Parabens voce acertou!
echo Numero sorteado: %numero%
echo ---------------------------
echo.
set /p resp=Deseja jogar novamente? [S/N]:
if /i %resp% == s (goto:Sorteio) else (exit)

:menor
echo.
echo ------------------------------
echo Boa tentativa!
echo Tente escolher um numero maior!
echo -------------------------------
echo.
pause
goto diminuir

:maior
echo.
echo ------------------------------
echo Boa tentativa!
echo Tente escolher um numero menor!
echo -------------------------------
echo.
pause
goto diminuir

:diminuir
set /a tentativas=%tentativas%-1
goto Inicio

