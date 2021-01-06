using System.ComponentModel;

namespace TailBlazor.HeroIcons {
    public enum HeroIcon {
        
        [Description("zoom-out")]
        ZoomOut,

        [Description("zoom-in")]
        ZoomIn,

        [Description("x")]
        X,

        [Description("x-circle")]
        XCircle,

        [Description("wifi")]
        Wifi,

        [Description("volume-up")]
        VolumeUp,

        [Description("volume-off")]
        VolumeOff,

        [Description("view-list")]
        ViewList,

        [Description("view-grid")]
        ViewGrid,

        [Description("view-grid-add")]
        ViewGridAdd,

        [Description("view-boards")]
        ViewBoards,

        [Description("video-camera")]
        VideoCamera,

        [Description("variable")]
        Variable,

        [Description("users")]
        Users,

        [Description("user")]
        User,

        [Description("user-remove")]
        UserRemove,

        [Description("user-group")]
        UserGroup,

        [Description("user-circle")]
        UserCircle,

        [Description("user-add")]
        UserAdd,

        [Description("upload")]
        Upload,

        [Description("truck")]
        Truck,

        [Description("trending-up")]
        TrendingUp,

        [Description("trending-down")]
        TrendingDown,

        [Description("trash")]
        Trash,

        [Description("translate")]
        Translate,

        [Description("ticket")]
        Ticket,

        [Description("thumb-up")]
        ThumbUp,

        [Description("thumb-down")]
        ThumbDown,

        [Description("terminal")]
        Terminal,

        [Description("template")]
        Template,

        [Description("tag")]
        Tag,

        [Description("table")]
        Table,

        [Description("switch-vertical")]
        SwitchVertical,

        [Description("switch-horizontal")]
        SwitchHorizontal,

        [Description("support")]
        Support,

        [Description("sun")]
        Sun,

        [Description("stop")]
        Stop,

        [Description("status-online")]
        StatusOnline,

        [Description("status-offline")]
        StatusOffline,

        [Description("star")]
        Star,

        [Description("speakerphone")]
        SpeakerPhone,

        [Description("sparkles")]
        Sparkles,

        [Description("sort-descending")]
        SortDescending,

        [Description("sort-ascending")]
        SortAscending,

        [Description("shopping-cart")]
        ShoppingCart,

        [Description("shopping-bag")]
        ShoppingBag,

        [Description("shield-exclamation")]
        ShieldExclamation,

        [Description("shield-check")]
        ShieldCheck,

        [Description("share")]
        Share,

        [Description("server")]
        Server,

        [Description("selector")]
        Selector,

        [Description("search")]
        Search,

        [Description("search-circle")]
        SearchCircle,

        [Description("scissors")]
        Scissors,

        [Description("scale")]
        Scale,

        [Description("save")]
        Save,

        [Description("save-as")]
        SaveAs,

        [Description("rss")]
        Rss,

        [Description("rewind")]
        Rewind,

        [Description("reply")]
        Reply,

        [Description("refresh")]
        Refresh,

        [Description("receipt-tax")]
        ReceiptTax,

        [Description("receipt-refund")]
        ReceiptRefund,

        [Description("question-mark-circle")]
        QuestionMarkCircle,

        [Description("qrcode")]
        QrCode,

        [Description("puzzle")]
        Puzzle,

        [Description("printer")]
        Printer,

        [Description("presentation-chart-line")]
        PresentationChartLine,

        [Description("presentation-chart-bar")]
        PresentationChartBar,

        [Description("plus")]
        Plus,

        [Description("plus-sm")]
        PlusSm,

        [Description("plus-circle")]
        PlusCircle,

        [Description("play")]
        Play,

        [Description("photograph")]
        Photograph,

        [Description("phone")]
        Phone,

        [Description("phone-outgoing")]
        PhoneOutgoing,

        [Description("phone-missed-call")]
        PhoneMissedCall,

        [Description("phone-incoming")]
        PhoneIncoming,

        [Description("pencil")]
        Pencil,

        [Description("pencil-alt")]
        PencilAlt,

        [Description("pause")]
        Pause,

        [Description("paper-clip")]
        PaperClip,

        [Description("paper-airplane")]
        PaperAirplane,

        [Description("office-building")]
        OfficeBuilding,

        [Description("newspaper")]
        Newspaper,

        [Description("music-note")]
        MusicNote,

        [Description("moon")]
        Moon,

        [Description("minus")]
        Minus,

        [Description("minus-sm")]
        MinusSm,

        [Description("minus-circle")]
        MinusCircle,

        [Description("microphone")]
        Microphone,

        [Description("menu")]
        Menu,

        [Description("menu-alt-4")]
        MenuAlt4,

        [Description("menu-alt-3")]
        MenuAlt3,

        [Description("menu-alt-2")]
        MenuAlt2,

        [Description("menu-alt-1")]
        MenuAlt1,

        [Description("map")]
        Map,

        [Description("mail")]
        Mail,

        [Description("mail-open")]
        MailOpen,

        [Description("logout")]
        Logout,

        [Description("login")]
        Login,

        [Description("lock-open")]
        LockOpen,

        [Description("lock-closed")]
        LockClosed,

        [Description("location-marker")]
        LocationMarker,

        [Description("link")]
        Link,

        [Description("lightning-bolt")]
        LightningBolt,

        [Description("light-bulb")]
        LightBulb,

        [Description("library")]
        Library,

        [Description("key")]
        Key,

        [Description("information-circle")]
        InformationCircle,

        [Description("inbox")]
        Inbox,

        [Description("inbox-in")]
        InboxIn,

        [Description("identification")]
        Identification,

        [Description("home")]
        Home,

        [Description("heart")]
        Heart,

        [Description("hashtag")]
        Hashtag,

        [Description("hand")]
        Hand,

        [Description("globe")]
        Globe,

        [Description("globe-alt")]
        GlobeAlt,

        [Description("gift")]
        Gift,

        [Description("folder")]
        Folder,

        [Description("folder-remove")]
        FolderRemove,

        [Description("folder-open")]
        FolderOpen,

        [Description("folder-download")]
        FolderDownload,

        [Description("folder-add")]
        FolderAdd,

        [Description("flag")]
        Flag,

        [Description("fire")]
        Fire,

        [Description("finger-print")]
        FingerPrint,

        [Description("filter")]
        Filter,

        [Description("film")]
        Film,

        [Description("fast-forward")]
        FastForward,

        [Description("eye")]
        Eye,

        [Description("eye-off")]
        EyeOff,

        [Description("external-link")]
        ExternalLink,

        [Description("exclamation")]
        Exclamation,

        [Description("exclamation-circle")]
        ExclamationCircle,

        [Description("emoji-sad")]
        EmojiSad,

        [Description("emoji-happy")]
        EmojiHappy,

        [Description("duplicate")]
        Duplicate,

        [Description("download")]
        Download,

        [Description("dots-vertical")]
        DotsVertical,

        [Description("dots-horizontal")]
        DotsHorizontal,

        [Description("dots-circle-horizontal")]
        DotsCircleHorizontal,

        [Description("document")]
        Document,

        [Description("document-text")]
        DocumentText,

        [Description("document-search")]
        DocumentSearch,

        [Description("document-report")]
        DocumentReport,

        [Description("document-remove")]
        DocumentRemove,

        [Description("document-duplicate")]
        DocumentDuplicate,

        [Description("document-download")]
        DocumentDownload,

        [Description("document-add")]
        DocumentAdd,

        [Description("device-tablet")]
        DeviceTablet,

        [Description("device-mobile")]
        DeviceMobile,

        [Description("desktop-computer")]
        DesktopComputer,

        [Description("database")]
        Database,

        [Description("cursor-click")]
        CursorClick,

        [Description("currency-yen")]
        CurrencyYen,

        [Description("currency-rupee")]
        CurrencyRupee,

        [Description("currency-pound")]
        CurrencyPound,

        [Description("currency-euro")]
        CurrencyEuro,

        [Description("currency-dollar")]
        CurrencyDollar,

        [Description("currency-bangladeshi")]
        CurrencyBangladeshi,

        [Description("cube")]
        Cube,

        [Description("cube-transparent")]
        CubeTransparent,

        [Description("credit-card")]
        CreditCard,

        [Description("color-swatch")]
        ColorSwatch,

        [Description("collection")]
        Collection,

        [Description("cog")]
        Cog,

        [Description("code")]
        Code,

        [Description("cloud")]
        Cloud,

        [Description("cloud-upload")]
        CloudUpload,

        [Description("cloud-download")]
        CloudDownload,

        [Description("clock")]
        Clock,

        [Description("clipboard")]
        Clipboard,

        [Description("clipboard-list")]
        ClipboardList,

        [Description("clipboard-copy")]
        ClipboardCopy,

        [Description("clipboard-check")]
        ClipboardCheck,

        [Description("chip")]
        Chip,

        [Description("chevron-up")]
        ChevronUp,

        [Description("chevron-right")]
        ChevronRight,

        [Description("chevron-left")]
        ChevronLeft,

        [Description("chevron-down")]
        ChevronDown,

        [Description("chevron-double-up")]
        ChevronDoubleUp,

        [Description("chevron-double-right")]
        ChevronDoubleRight,

        [Description("chevron-double-left")]
        ChevronDoubleLeft,

        [Description("chevron-double-down")]
        ChevronDoubleDown,

        [Description("check")]
        Check,

        [Description("check-circle")]
        CheckCircle,

        [Description("chat")]
        Chat,

        [Description("chat-alt")]
        ChatAlt,

        [Description("chat-alt-2")]
        ChatAlt2,

        [Description("chart-square-bar")]
        ChartSquareBar,

        [Description("chart-pie")]
        ChartPie,

        [Description("chart-bar")]
        ChartBar,

        [Description("cash")]
        Cash,

        [Description("camera")]
        Camera,

        [Description("calendar")]
        Calendar,

        [Description("calculator")]
        Calculator,

        [Description("cake")]
        Cake,

        [Description("briefcase")]
        Briefcase,

        [Description("bookmark")]
        Bookmark,

        [Description("bookmark-alt")]
        BookmarkAlt,

        [Description("book-open")]
        BookOpen,

        [Description("bell")]
        Bell,

        [Description("beaker")]
        Beaker,

        [Description("ban")]
        Ban,

        [Description("badge-check")]
        BadgeCheck,

        [Description("backspace")]
        BackSpace,

        [Description("at-symbol")]
        AtSymbol,

        [Description("arrows-expand")]
        ArrowsExpand,

        [Description("arrow-up")]
        ArrowUp,

        [Description("arrow-right")]
        ArrowRight,

        [Description("arrow-narrow-right")]
        ArrowNarrowRight,

        [Description("arrow-narrow-left")]
        ArrowNarrowLeft,

        [Description("arrow-narrow-down")]
        ArrowNarrowDown,

        [Description("arrow-narrow-up")]
        ArrowNarrowUp,

        [Description("arrow-left")]
        ArrowLeft,

        [Description("arrow-down")]
        ArrowDown,

        [Description("arrow-circle-up")]
        ArrowCircleUp,

        [Description("arrow-circle-right")]
        ArrowCircleRight,

        [Description("arrow-circle-left")]
        ArrowCircleLeft,

        [Description("arrow-circle-down")]
        ArrowCircleDown,

        [Description("archive")]
        Archive,

        [Description("annotation")]
        Annotation,

        [Description("adjustments")]
        Adjustments,

        [Description("academic-cap")]
        AcademicCap,
    }
}
