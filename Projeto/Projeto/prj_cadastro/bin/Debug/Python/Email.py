import pyautogui as py
import time as t

#Entra no navegador
py.press('winleft')
py.write('chrome')
py.press('enter')
t.sleep(2)

#Digita a url do site
py.write('https://www.ouvirmusica.com.br/')
py.press('enter')
t.sleep(12)

#Clica no botão de login
py.moveTo(1594, 173)
py.click()
t.sleep(1)

#Seleciona a textbox do email e o digita
py.moveTo(1298, 289)
py.click()
py.write('tes150925@gmail.com')
t.sleep(0.5)

#Seleciona a textbox da senha e a digita
py.moveTo(1247, 348)
py.click()
py.write('tes150925')
t.sleep(1)

#Clica no botão para entrar na conta
py.moveTo(1553, 420)
py.click()
t.sleep(5)

#Seleciona a música 
py.moveTo(570, 689)
py.click()


