# MVC_Moment2

Uppgiften består i att utveckla en valfri applikation, baserad på ASP.NET Core MVC. Målet är att göra en sammanhållen applikation som med de olika pusselbitarna. Se till att den inte upplevs som separata delar. Applikationen kan dock vara enkel och bara ha till syfte att ni ska lära er detta men roliga kreativa tolkningar uppskattas alltid.

Målet är att ni ska:

- Ska skapa ett enkelt projekt som bygger på designmönstret MVC.
- Förstå filuppdelningen och MVC-arkitekturen.
- Förstå kopplingen mellan routing,URL och vilken kod som exekveras i controllern.
- Förstå var logik skall placeras och varför.


För godkänt genomförande av laboration ska ni i er applikation visa på följande:

- Att ni verkligen använder Models, Controller och Vyer (Views).
- På något sätt ändra grundroutingen.
- Skicka data: manipulera/uppdatera/beräkna i controller, mata in/interagera med i Views, möjligtvis spara/hämta i Model (utan databaskoppling).
- Ha minst tre separata Views.
- Skicka data från controllern och vyn med tre varianter: ViewBag, ViewData och parameterpassning med en vy-modell i grunden.Förklaring på parameterpassningen: action-metoden returnerar return view(namnet_på_en_instans_av_en_modell) istället för enbart en return view().
- Spara data så att det finns tillgängligt då man går från en sida till en annan. Session och/eller Cookie.
