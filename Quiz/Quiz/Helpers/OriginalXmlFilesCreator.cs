using Quiz.Entities;
using System;
using System.Collections.Generic;

namespace Quiz.Helpers;

public static class OriginalXmlFilesCreator
{
    public static void Create()
    {
        CreateUsersXml();
        CreateGeographyXml();
        CreateHistoryXml();
        CreateBiologyXml();
    }

    private static void CreateUsersXml()
    {
        List<User> users =
        [
            new("Admin", Utile.TextEncryptor.Encrypt("1"), DateTime.MinValue)
        ];

        Utile.SerializeHelper.Serialize(users, Constants.UsersXmlPath);
    }

    private static void CreateBiologyXml()
    {
        List<Question> questions =
        [
            new(Topic.Biology,
            "Какое вещество есть в оболочках клеток грибов и наружном скелете насекомых?",
            new List<(bool, string)>
            {
                (true, "Хитин"),
                (false, "Хлорофил"),
                (false, "Биотин")
            }),
            new(Topic.Biology,
            "Как называется группа организмов, являющаяся сожительством грибов и водорослей?",
            new List<(bool, string)>
            {
                (true, "Лишайники"),
                (false, "Мхи"),
                (false, "Плесень")
            }),
            new(Topic.Biology, 
            "Как называются листья папоротников?",
            new List<(bool, string)>
            {
                (true, "Вайи"),
                (false, "Вейрушки"),
                (false, "Вертопласты")
            }),
            new(Topic.Biology,
            "Что из перечисленного не имеет запаса питательных веществ?",
            new List<(bool, string)>
            {
                (true, "Спора"),
                (false, "Семя"),
                (false, "Плод")
            }),
            new(Topic.Biology,
            "Какое из перечисленных растений не относится к голосемянным растениям?",
            new List<(bool, string)>
            {
                (true, "Яблоня"),
                (false, "Сосна"),
                (false, "Кипарис"),
                (false, "Берёза")
            }),
            new(Topic.Biology,
            "Как называются первые листья зародыша в семени покрытосеменных растений?",
            new List<(bool, string)>
            {
                (true, "Семядоли"),
                (false, "Листочки"),
                (false, "Семялистья"),
                (false, "Листинки")
            }),
            new(Topic.Biology,
            "Чем являются колючки у кактусов?",
            new List<(bool, string)>
            {
                (true, "Видоизмененными листьями"),
                (false, "Видоизмененными корнями"),
                (false, "Видоизмененными побегами")
            }),
            new(Topic.Biology,
            "У кого пестичные и тычиночные цветки развиваются на одном растении?",
            new List<(bool, string)>
            {
                (true, "У однодомных растений"),
                (false, "У двудомных растений")
            }),
            new(Topic.Biology,
            "Как называется сочный плод с мякотью, покрытый снаружи тонкой кожурой?",
            new List<(bool, string)>
            {
                (true, "Ягода"),
                (false, "Орех"),
                (false, "Фрукт")
            }),
            new(Topic.Biology,
            "К какому семейству относятся рожь, пшеница и овес?",
            new List<(bool, string)>
            {
                (true, "Злаки"),
                (false, "Хвойные"),
                (false, "Мхи")
            }),
            new(Topic.Biology,
            "Как называется процесс восстановления утраченных или поврежденных частей тела животных?",
            new List<(bool, string)>
            {
                (true, "Регенерация"),
                (false, "Реинтеграция"),
                (false, "Ремобилизация")
            }),
            new(Topic.Biology,
            "Как называется одновременное наличие у организма мужских и женских половых признаков?",
            new List<(bool, string)>
            {
                (true, "Гермафродитизм"),
                (false, "Бесполость"),
                (false, "Двуполость")
            }),
            new(Topic.Biology,
            "Какое животное не относится к головоногим моллюскам?",
            new List<(bool, string)>
            {
                (true, "Медуза"),
                (false, "Каракатица"),
                (false, "Осьминог")
            }),
            new(Topic.Biology,
            "Как называется личинка бабочки?",
            new List<(bool, string)>
            {
                (true, "Гусеница"),
                (false, "Червяк"),
                (false, "Жук")
            }),
            new(Topic.Biology,
            "Каких насекомых люди разводят для получения шелка?",
            new List<(bool, string)>
            {
                (true, "Бабочек"),
                (false, "Жуков"),
                (false, "Пауков"),
                (false, "Пчёл")
            }),
            new(Topic.Biology,
            "Как называется чувствительный орган рыб, позволяющий улавливать направление и силу тока воды?",
            new List<(bool, string)>
            {
                (true, "Боковая линия"),
                (false, "Хорда"),
                (false, "Плавники"),
                (false, "Глаз")
            }),
            new(Topic.Biology,
            "Как называется раздел биологии, изучающий живые клетки?",
            new List<(bool, string)>
            {
                (true, "Цитология"),
                (false, "Клетковедение"),
                (false, "Цитономия")
            }),
            new(Topic.Biology,
            "Как называется внутреннее содержание клетки исключая её ядерный аппарат?",
            new List<(bool, string)>
            {
                (true, "Цитоплазма"),
                (false, "Лизосома"),
                (false, "Митохондрия")
            }),
            new(Topic.Biology,
            "Из скольких костей состоит скелет человека?",
            new List<(bool, string)>
            {
                (true, "около 200"),
                (false, "около 100"),
                (false, "около 300"),
                (false, "около 400")
            }),
            new(Topic.Biology,
            "Как называется врожденный возврат к признакам предка у человека?",
            new List<(bool, string)>
            {
                (true, "Атавизм"),
                (false, "Мутизм"),
                (false, "Хиропризм")
            }),
            new(Topic.Biology,
            "Как называются клетки крови человека, имеющие ядра?",
            new List<(bool, string)>
            {
                (true, "Лейкоциты"),
                (false, "Эритроциты"),
                (false, "Тромбоциты")
            }),
            new(Topic.Biology,
            "Людей с какой группой крови называют универсальными донорами?",
            new List<(bool, string)>
            {
                (true, "I(0)"),
                (false, "II(A)"),
                (false, "III(B)"),
                (false, "IV(AB)")
            }),
            new(Topic.Biology,
            "Как называются кровеносные сосуды человека, по которым кровь идёт от сердца к органам и тканям?",
            new List<(bool, string)>
            {
                (true, "Артерии"),
                (false, "Вены"),
                (false, "Капилляры")
            }),
            new(Topic.Biology,
            "Как называется самый большой внутренний орган человека?",
            new List<(bool, string)>
            {
                (true, "Печень"),
                (false, "Сердце"),
                (false, "Лёгкие"),
                (false, "Желудок")
            }),
            new(Topic.Biology,
            "Как называются белковые молекулы, ускоряющие протекание химических реакций в организме?",
            new List<(bool, string)>
            {
                (true, "Ферменты"),
                (false, "Желчь"),
                (false, "Лейкоциты")
            }),
        ];

        Utile.SerializeHelper.Serialize(questions, Constants.BiologyXmlPath);
    }

    private static void CreateGeographyXml()
    {
        List<Question> questions =
        [
            new(Topic.Geography,
            "Как называется река, протекающая через бразильские тропические леса?",
            new List<(bool, string)>
            {
                (true, "Амазонка"),
                (false, "Парана"),
                (false, "Паранаиба"),
                (false, "Токантинс")
            }),
            new(Topic.Geography,
            "Какую страну также называют Нидерландами?",
            new List<(bool, string)>
            {
                (true, "Голландия"),
                (false, "Германия"),
                (false, "Португалия"),
                (false, "Франция")
            }),
            new(Topic.Geography,
            "Где находится самый большой вулкан на Земле?",
            new List<(bool, string)>
            {
                (true, "Гавайи"),
                (false, "Мадагаскар"),
                (false, "Гренландия"),
                (false, "Таити")
            }),
            new(Topic.Geography,
            "Как называется самая большая река, протекающая через Париж?",
            new List<(bool, string)>
            {
                (true, "Сена"),
                (false, "Луара"),
                (false, "Рейн"),
                (false, "Мозель")
            }),
            new(Topic.Geography,
            "Как называется столица Канады?",
            new List<(bool, string)>
            {
                (true, "Оттава"),
                (false, "Монреаль"),
                (false, "Калгари"),
                (false, "Эдмонтон")
            }),
            new(Topic.Geography,
            "Как называется самая длинная река Африки?",
            new List<(bool, string)>
            {
                (true, "Нил"),
                (false, "Замбези"),
                (false, "Конго"),
                (false, "Лимпопо")
            }),
            new(Topic.Geography,
            "Как называется самая большая страна в мире?",
            new List<(bool, string)>
            {
                (true, "Россия"),
                (false, "Канада"),
                (false, "Индия"),
                (false, "Колумбия")
            }),
            new(Topic.Geography,
            "В какой стране находятся Великие пирамиды Гизы?",
            new List<(bool, string)>
            {
                (true, "Египет"),
                (false, "Мексика"),
                (false, "Индия"),
                (false, "Колумбия")
            }),
            new(Topic.Geography,
            "Какая единственная страна граничит с Великобританией?",
            new List<(bool, string)>
            {
                (true, "Ирландия"),
                (false, "Франция"),
                (false, "Бельгия"),
                (false, "Нидерланды")
            }),
            new(Topic.Geography,
            "Какой штат США самый большой по площади?",
            new List<(bool, string)>
            {
                (true, "Аляска"),
                (false, "Техас"),
                (false, "Калифорния"),
                (false, "Аризона")
            }),
            new(Topic.Geography,
            "Какая самая большая столица в Северной Америке?",
            new List<(bool, string)>
            {
                (true, "Мехико"),
                (false, "Гавана"),
                (false, "Вашингтон"),
                (false, "Оттава")
            }),
            new(Topic.Geography,
            "Какой стране принадлежат Канарские острова?",
            new List<(bool, string)>
            {
                (true, "Испания"),
                (false, "Мавритания"),
                (false, "Марокко"),
                (false, "Португалия")
            }),
            new(Topic.Geography,
            "Какой город является самым густонаселенным в мире?",
            new List<(bool, string)>
            {
                (true, "Манила"),
                (false, "Москва"),
                (false, "Тегеран"),
                (false, "Чикаго")
            }),
            new(Topic.Geography,
            "Как называется единственное море, не имеющее береговой линии?",
            new List<(bool, string)>
            {
                (true, "Саргассово"),
                (false, "Северное"),
                (false, "Аравийское"),
                (false, "Адриатическое")
            }),
            new(Topic.Geography,
            "Как называется столица штата Нью-Йорк?",
            new List<(bool, string)>
            {
                (true, "Олбани"),
                (false, "Нью-Йорк"),
                (false, "Сиракьюс"),
                (false, "Кингстон")
            }),
            new(Topic.Geography,
            "Как называется столица Австралии?",
            new List<(bool, string)>
            {
                (true, "Канберра"),
                (false, "Мельбурн"),
                (false, "Сидней"),
                (false, "Брисбен")
            }),
            new(Topic.Geography,
            "Как называется столица штата Техас?",
            new List<(bool, string)>
            {
                (true, "Остин"),
                (false, "Даллас"),
                (false, "Хьюстон"),
                (false, "Арлингтон")
            }),
            new(Topic.Geography,
            "Столицей какой страны является Баку?",
            new List<(bool, string)>
            {
                (true, "Азербайджан"),
                (false, "Сумгаит"),
                (false, "Гянджа"),
                (false, "Агджабеди")
            }),
            new(Topic.Geography,
            "Как называется столица Белоруссии?",
            new List<(bool, string)>
            {
                (true, "Минск"),
                (false, "Гомель"),
                (false, "Брест"),
                (false, "Витебск")
            }),
            new(Topic.Geography,
            "Камден и Брикстон являются районами какой столицы?",
            new List<(bool, string)>
            {
                (true, "Лондон"),
                (false, "Дублин"),
                (false, "Стокгольм"),
                (false, "Амстердам")
            }),
            new(Topic.Geography,
            "Как называется столица Камбоджи?",
            new List<(bool, string)>
            {
                (true, "Пномпень"),
                (false, "Баттамбанг"),
                (false, "Сисопхон"),
                (false, "Сиемреап")
            }),
            new(Topic.Geography,
            "Столицей какой страны является Вадуц?",
            new List<(bool, string)>
            {
                (true, "Лихтенштейн"),
                (false, "Австрия"),
                (false, "Варшава"),
                (false, "Венгрия")
            }),
            new(Topic.Geography,
            "Как называется столица Того?",
            new List<(bool, string)>
            {
                (true, "Ломе"),
                (false, "Сокоде"),
                (false, "Кара"),
                (false, "Кпалиме")
            }),
            new(Topic.Geography,
            "Как называется столица Южной Кореи?",
            new List<(bool, string)>
            {
                (true, "Сеул"),
                (false, "Пхеньян"),
                (false, "Пусан"),
                (false, "Сувон")
            }),
            new(Topic.Geography,
            "В какой океан впадает река Амазонка?",
            new List<(bool, string)>
            {
                (true, "Атлантический"),
                (false, "Тихий"),
                (false, "Индийский"),
                (false, "Южный")
            }),
            new(Topic.Geography,
            "Как называется столица Новой Зеландии?",
            new List<(bool, string)>
            {
                (true, "Веллингтон"),
                (false, "Окленд"),
                (false, "Крайстчерч"),
                (false, "Гамильтон")
            }),
            new(Topic.Geography,
            "Как называется замок, вдохновивший Уолта Диснея на создание замка Золушки в фильме 1950 года?",
            new List<(bool, string)>
            {
                (true, "Нойшванштайн"),
                (false, "Мариенбург"),
                (false, "Тракайский"),
                (false, "Кронборг")
            }),
            new(Topic.Geography,
            "La Sagrada Familia — известная достопримечательность Испании. В каком городе он находится?",
            new List<(bool, string)>
            {
                (true, "Барселона"),
                (false, "Мадрид"),
                (false, "Севилья"),
                (false, "Валенсия")
            }),
            new(Topic.Geography,
            "Какой культовый мост расположен рядом с Лондонским Тауэром?",
            new List<(bool, string)>
            {
                (true, "Тауэрский"),
                (false, "Ватерлоо"),
                (false, "Вестминстерский"),
                (false, "Миллениум")
            }),
            new(Topic.Geography,
            "В какой стране находятся Линии Наска?",
            new List<(bool, string)>
            {
                (true, "Перу"),
                (false, "Венесуэла"),
                (false, "Боливия"),
                (false, "Эквадор")
            }),
        ];

        Utile.SerializeHelper.Serialize(questions, Constants.GeographyXmlPath);
    }

    private static void CreateHistoryXml()
    {
        List<Question> questions =
        [
            new(Topic.History,
            "Как называлась столица Древнего Египта?",
            new List<(bool, string)>
            {
                (true, "Мемфис"),
                (false, "Вавилон"),
                (false, "Каир"),
                (false, "Асуан")
            }),
            new(Topic.History,
            "Какому фараону была построена самая большая пирамида?",
            new List<(bool, string)>
            {
                (true, "Хеопсу"),
                (false, "Хефрену"),
                (false, "Джосеру"),
                (false, "Эхнатон")
            }),
            new(Topic.History,
            "Как называли бога Солнца – самого могущественного бога Древнего Египта?",
            new List<(bool, string)>
            {
                (true, "Амон-Ра"),
                (false, "Осирис"),
                (false, "Анубис"),
                (false, "Сет")
            }),
            new(Topic.History,
            "Какому богу были посвящены Олимпийские игры в Древней Греции?",
            new List<(bool, string)>
            {
                (true, "Зевсу"),
                (false, "Аполлону"),
                (false, "Посейдону"),
                (false, "Аресу")
            }),
            new(Topic.History,
            "Какой древнегреческий поэт был автором поэм «Илиада» и «Одиссея»?",
            new List<(bool, string)>
            {
                (true, "Гомер"),
                (false, "Эсхил"),
                (false, "Аристофан"),
                (false, "Алкей")
            }),
            new(Topic.History,
            "Какое животное по легенде выкормило братьев Ромула и Рема – основателей Древнего Рима?",
            new List<(bool, string)>
            {
                (true, "Волчица"),
                (false, "Медведица"),
                (false, "Лиса"),
                (false, "Кабаниха")
            }),
            new(Topic.History,
            "Как назывался народ, издавна населявший Англию?",
            new List<(bool, string)>
            {
                (true, "Бритты"),
                (false, "Англы"),
                (false, "Норманны"),
                (false, "Саксы")
            }),
            new(Topic.History,
            "К какой королевской династии принадлежал Карл Великий?",
            new List<(bool, string)>
            {
                (true, "Меровинги"),
                (false, "Каролинги"),
                (false, "Бурбоны"),
                (false, "Веттины")
            }),
            new(Topic.History,
            "В каких произведениях описывались приключения Робина Гуда?",
            new List<(bool, string)>
            {
                (true, "Баллады"),
                (false, "Романы"),
                (false, "Летописи"),
                (false, "Былина")
            }),
            new(Topic.History,
            "Кем была создана огромная держава монголов?",
            new List<(bool, string)>
            {
                (true, "Чингизханом"),
                (false, "Тамерланом"),
                (false, "Батыем"),
                (false, "Угэдэйем")
            }),
            new(Topic.History,
            "От какой империи Россия унаследовала двуглавого орла на гербе?",
            new List<(bool, string)>
            {
                (true, "Византийской"),
                (false, "Китайской"),
                (false, "Османской"),
                (false, "Британской")
            }),
            new(Topic.History,
            "Кто был первым русским царём?",
            new List<(bool, string)>
            {
                (true, "Иван IV Грозный"),
                (false, "Пётр I"),
                (false, "Иван Калита"),
                (false, "Михаил Романов")
            }),
            new(Topic.History,
            "Какой город был столицей России в XVII веке?",
            new List<(bool, string)>
            {
                (true, "Москва"),
                (false, "Ярославль"),
                (false, "Санкт-Петербург"),
                (false, "Нижний Новгород")
            }),
            new(Topic.History,
            "Первым русским царём из династии Романовых стал?",
            new List<(bool, string)>
            {
                (true, "Михаил Фёдорович"),
                (false, "Пётр Алексеевич"),
                (false, "Алексей Михайлович"),
                (false, "Иван Алексеевич")
            }),
            new(Topic.History,
            "Кто был первым русским императором?",
            new List<(bool, string)>
            {
                (true, "Пётр I"),
                (false, "Павел I"),
                (false, "Александр I"),
                (false, "Николай I")
            }),
            new(Topic.History,
            "В каком веке Россия стала империей?",
            new List<(bool, string)>
            {
                (true, "XVIII"),
                (false, "XVII"),
                (false, "XIX"),
                (false, "XVI")
            }),
            new(Topic.History,
            "Какой титул получил Наполеон в 1804 году?",
            new List<(bool, string)>
            {
                (true, "Император"),
                (false, "Король"),
                (false, "Царь"),
                (false, "Герцог")
            }),
            new(Topic.History,
            "В начале царствования какого императора произошло восстание декабристов?",
            new List<(bool, string)>
            {
                (true, "Николая I"),
                (false, "Александра I"),
                (false, "Павла I"),
                (false, "Петра I")
            }),
            new(Topic.History,
            "Какой император отменил в 1861 году в России крепостное право?",
            new List<(bool, string)>
            {
                (true, "Александр II"),
                (false, "Николай I"),
                (false, "Николай II"),
                (false, "Павел I")
            }),
            new(Topic.History,
            "В каком году в России произошли 2 революции?",
            new List<(bool, string)>
            {
                (true, "1917г."),
                (false, "1914г."),
                (false, "1905г."),
                (false, "1907г.")
            }),
            new(Topic.History,
            "В честь какого полководца немецкие захватчики назвали план нападения на СССР в 1941 году?",
            new List<(bool, string)>
            {
                (true, "Барбароссы"),
                (false, "Тамерлана"),
                (false, "Наполеона"),
                (false, "Македонского")
            }),
            new(Topic.History,
            "Какой день в Древней Руси называли «неделя»?",
            new List<(bool, string)>
            {
                (true, "Воскресенье"),
                (false, "Суббота"),
                (false, "Понедельник"),
                (false, "Пятница")
            }),
            new(Topic.History,
            "Какую игру великий русский полководец А.В.Суворов утвердил как часть программы военной подготовки?",
            new List<(bool, string)>
            {
                (true, "Городки"),
                (false, "Шашки"),
                (false, "Шахматы"),
                (false, "Прятки")
            }),
            new(Topic.History,
            "Сколько корон изображено на гербе России?",
            new List<(bool, string)>
            {
                (true, "Три"),
                (false, "Две"),
                (false, "Четыре"),
                (false, "Одна")
            }),
            new(Topic.History,
            "У какого бога древние греки просили успешного плавания кораблю?",
            new List<(bool, string)>
            {
                (true, "Посейдона"),
                (false, "Зевса"),
                (false, "Аполлона"),
                (false, "Ареса")
            }),
            new(Topic.History,
            "На каком полуострове располагался Древний Рим?",
            new List<(bool, string)>
            {
                (true, "Апеннинском"),
                (false, "Пиренейском"),
                (false, "Балканском"),
                (false, "Скандинавском")
            }),
            new(Topic.History,
            "Как в средние века называлось земельное владение, за которое несли военную службу?",
            new List<(bool, string)>
            {
                (true, "Феод"),
                (false, "Оброк"),
                (false, "Титул"),
                (false, "Латифундия")
            }),
            new(Topic.History,
            "Когда Москва впервые упомянута в летописи?",
            new List<(bool, string)>
            {
                (true, "1147г."),
                (false, "988г."),
                (false, "1223г."),
                (false, "1001г.")
            }),
            new(Topic.History,
            "Какую реку перешёл Цезарь, тем самым начав войну с римским сенатом?",
            new List<(bool, string)>
            {
                (true, "Рубикон"),
                (false, "Тибр"),
                (false, "Аньен"),
                (false, "Ганик")
            }),
            new(Topic.History,
            "Какой город выдержал во время Великой Отечественной войны 900-дневную осаду немецких войск?",
            new List<(bool, string)>
            {
                (true, "Ленинград"),
                (false, "Киев"),
                (false, "Севастополь"),
                (false, "Смоленск")
            }),
        ];

        Utile.SerializeHelper.Serialize(questions, Constants.HistoryXmlPath);
    }
}