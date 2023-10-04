# AfsluitingMasterclass

## Background
We hebben allemaal wel informatie die we dagelijks googlen of opzoeken in een app, zoals het weerbericht, het nieuws etc.
Zou het niet fijn zijn als je deze informatie elke ochtend als een email zou ontvangen, zodat je het niet zelf bij elkaar hoeft te zoeken?
Om dit te automatiseren zou je bijvoorbeeld een Azure function kunnen maken - een programmaatje dat dagelijks draait, en deze informatie via api's ophaalt en dan naar je toestuurt via de mail.

In deze repo staan opdrachten waarmee je zelf een Azure Function kan maken die je elke 5 minuten een email stuurt met het weerbericht van vandaag.
We hebben gekozen voor 5 minuten zodat je snel weet of het werkt, en later zou dit natuurlijk veranderd kunnen worden in een dagelijkse trigger. 
Momenteel wordt er alleen een call gedaan naar een weather api, maar dit is natuurlijk uit te breiden met elke mogelijke api die je zou willen. 

Met deze opdracht proberen we te laten zien dat je met Azure functions ook dagelijkse taken makkelijk zou kunnen automatiseren.

## Overview
In de folder Opdrachten staan 3 opdrachten die je achter elkaar kunt uitvoeren:
Opdracht 1: Opzetten van een sendgrid account zodat je mails kan sturen.
Opdracht 2: Opzetten van een sandbox zodat je 4 uur lang in de Azure Cloud kan werken.
Opdracht 3: Het maken van de Azure function die je automatisch emails laat sturen.
