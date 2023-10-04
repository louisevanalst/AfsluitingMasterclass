# Opdracht 3 - Creëer een azure function met een timer trigger die je elke 5 minuten een email met het weerbericht stuurt.

## Maak een azure function app
1. In de azure portal, klik op "Create new resource"
2. Je kan nu zoeken naar "Function app" in de zoekbalk, klik op function app -> "Create".
3. Je krijgt nu een scherm met "Create Function App".
4. Vul de volgende informatie in:
   - Subscription: Concierge Subscription (is al ingevuld)
   - Resource group: selecteer in de dropdown de enige resource group die er al is.
   - Function app name: functionappharvest[jouwnaam]  dus e.g. functionappharvestlouise
   - Do you want to deply code or container image: Code
   - Runtime stack: .NET
   - Version: 6 (LTS)
   - Region: West Europe
   - Operating system: Windows
   - Hosting options and plans: Consumption (Serverless)
5. Klik op Review + Create en dan nogmaals op Create
6. Je ziet nu een "Deployment is in progress" scherm. Wacht totdat de deployment klaar is en klik op "Go to resource".

## Vul de API key van Sendgrid in de appsettings in.
7. In het scherm van de function app, Klik links op het tabje settings -> Configuration
8. Klik op de + van New Application Setting. Vul het volgende in:
   - Name: SendGridApiKey
   - Value: de string die je net hebt gekopieerd van sendgrid
9. Klik op Ok en **Klik linksboven op Save**

## Maak de Azure function zelf
10. Ga terug naar het Overview tabje (linksboven)
11. Klik op "Create in Azure portal" om een functie te maken.
12. Vul de volgende informatie in:
    - Development environment: Develop in portal (al geselecteerd)
    - Select a template: Timer trigger
    - New Function: EmailWeatherFunction
    - Schedule: 0 */5 * * * * (staat er al, dit betekent dat je functie elke 5 minuten wordt uitgevoerd)
13. Klik op Create
14. Je krijgt nu een scherm met je functie te zien. Ga naar het tabje Code en Test (linksboven)
15. Je kan 3 verschillende files selecteren in de dropdown: run.csx, function.json en readme.md.
16. Ga naar de AzureFunctionFiles folder in deze repo, en vul in function.json bij "from" en "to" twee keer je eigen harvest email in.
17. Kopieer en plak **en save (linksboven)** de run.csx en function.json files in de azure portal.
18. Binnen 5 minuten zou je een email op je harvest account moeten ontvangen.

## Stop/Pauzeer de Azure function app zodat je niet continu emails ontvangt
18. Zoek in de zoekbalk midden bovenin de portal naar je function app.
19. Ga weer naar het overzicht tabje en klik linksbovenin op "Stop". Dit zorgt ervoor dat je geen emails meer ontvangt.
20. Na 4 uur wordt de sanbox automatisch opgeruimd, dus zal je sowieso geen mails meer ontvangen.
