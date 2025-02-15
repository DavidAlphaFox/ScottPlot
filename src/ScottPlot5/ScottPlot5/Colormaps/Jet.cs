/* The Jet colormap is provided under a MIT license.
 * Do not use this colormap for heatmap data! See references:
 * https://jakevdp.github.io/blog/2014/10/16/how-bad-is-your-colormap/
 * https://bids.github.io/colormap/
 * https://ai.googleblog.com/2019/08/turbo-improved-rainbow-colormap-for.html
 */

namespace ScottPlot.Colormaps;

public class Jet : IColormap
{
    public string Name => "Jet";
    private readonly CustomPalette Colormap;
    public Color GetColor(double position) => Colormap.GetColor(position);

    public Jet()
    {
        int[] rgbColors =
        {
            00000127, 00000132, 00000136, 00000141, 00000145, 00000150, 00000154, 00000159,
            00000163, 00000168, 00000172, 00000177, 00000182, 00000186, 00000191, 00000195,
            00000200, 00000204, 00000209, 00000213, 00000218, 00000222, 00000227, 00000232,
            00000236, 00000241, 00000245, 00000250, 00000254, 00000255, 00000255, 00000255,
            00000255, 00001279, 00002303, 00003327, 00004351, 00005375, 00006399, 00007423,
            00008447, 00009471, 00010495, 00011519, 00012543, 00013567, 00014591, 00015615,
            00016639, 00017663, 00018687, 00019711, 00020735, 00021759, 00022783, 00023807,
            00024831, 00025855, 00026879, 00027903, 00028927, 00029951, 00030975, 00031999,
            00033023, 00034047, 00035071, 00036095, 00037119, 00038143, 00039167, 00040191,
            00041215, 00042239, 00043263, 00044287, 00045311, 00046335, 00047359, 00048383,
            00049407, 00050431, 00051455, 00052479, 00053503, 00054527, 00055551, 00056574,
            00057594, 00058615, 00190708, 00388337, 00585965, 00849130, 01046759, 01244388,
            01441761, 01638365, 01900506, 02097111, 02293716, 02490320, 02752461, 02949066,
            03145671, 03342275, 03604416, 03801021, 03997626, 04194231, 04390835, 04652976,
            04849581, 05046186, 05242790, 05504931, 05701536, 05898141, 06094746, 06291350,
            06553491, 06750096, 06946701, 07143305, 07405446, 07602051, 07798656, 07995261,
            08191865, 08454006, 08650611, 08847216, 09043820, 09305961, 09502566, 09699171,
            09895775, 10157916, 10354521, 10551126, 10747731, 10944335, 11206476, 11403081,
            11599686, 11796290, 12058431, 12255036, 12451641, 12648246, 12844850, 13106991,
            13303596, 13500201, 13696805, 13958946, 14155551, 14352156, 14548760, 14745365,
            15007506, 15204111, 15400716, 15597320, 15858693, 16054274, 16249856, 16445440,
            16706816, 16771328, 16770304, 16769536, 16768512, 16767488, 16766720, 16765696,
            16764672, 16763648, 16762880, 16761856, 16760832, 16760064, 16759040, 16758016,
            16756992, 16756224, 16755200, 16754176, 16753408, 16752384, 16751360, 16750592,
            16749568, 16748544, 16747520, 16746752, 16745728, 16744704, 16743936, 16742912,
            16741888, 16741120, 16740096, 16739072, 16738048, 16737280, 16736256, 16735232,
            16734464, 16733440, 16732416, 16731392, 16730624, 16729600, 16728576, 16727808,
            16726784, 16725760, 16724992, 16723968, 16722944, 16721920, 16721152, 16720128,
            16719104, 16718336, 16717312, 16650752, 16387840, 16059136, 15795968, 15467264,
            15204352, 14876672, 14548992, 14286848, 13959168, 13697024, 13369344, 13107200,
            12779520, 12517376, 12189696, 11927552, 11599872, 11272192, 11010048, 10682368,
            10420224, 10092544, 09830400, 09502720, 09240576, 08912896, 08650752, 08323072,
        };

        Color[] colors = rgbColors.Select(rgb => unchecked((uint)(0xFF << 24) | (uint)rgb)).Select(Color.FromARGB).ToArray();

        Colormap = new CustomPalette(colors);
    }
}
