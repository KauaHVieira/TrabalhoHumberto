import pyautogui as py
import time as t
py.pause = 1.0
#pausa por 1 segundo a cada ação
py.press('winleft')
py.write('edge')
py.press('enter')
t.sleep(2)
py.write('https://www.uol.com.br', interval=0.05)
py.press('enter')
py.press('f11')
t.sleep(5)
py.moveTo(1901, 161)
py.click()
py.scroll(-1500)
t.sleep(1)
py.moveTo(1478, 430)
py.click()

#t.sleep(10)-Tempo de espera
#py.hotkey('alt', 'f4')-Tecla de atalho quando separado por vírgula

