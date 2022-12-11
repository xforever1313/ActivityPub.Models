//
//          Copyright Seth Hendrick 2022.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

namespace ActivityPub.Models
{
    public record class NoteLink : LinkType
    {
        public override string Type => "Note";
    }
}
