/**
 *   Copyright (C) 2021 okaygo
 *
 *   https://github.com/misterokaygo/MapAssist/
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <https://www.gnu.org/licenses/>.
 **/

namespace MapAssist.Types
{
    public static class Offsets
    {
        public static string UnitTableSignature = "4C 8D 05 ? ? ? ? 48 63 03";
        public static int UnitTable = -1;

        public static string InGameMapSignature = "44 0F B6 35 ? ? ? ? 33 D2 41 B0 01 8D 4A 0A";
        public static int InGameMap = -1;
    }
}
