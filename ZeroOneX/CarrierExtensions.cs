namespace ZeroOneX;

internal static class CarrierExtensions {
    public static string GetCarrierName(this Carrier carrier)
        => carrier switch {
            Carrier.Unknown => "알 수 없음",
            Carrier.SKTelecom => "SK텔레콤",
            Carrier.KT => "KT",
            Carrier.LGUPlus => "LG U+",
            _ => throw new ArgumentOutOfRangeException(nameof(carrier), carrier, null),
        };
}
