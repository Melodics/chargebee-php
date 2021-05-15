<?php

namespace ChargeBee\ChargeBee\Models;

use ChargeBee\ChargeBee\Model;

class UnbilledChargeTier extends Model
{
    protected $allowed = [
        'starting_unit',
        'ending_unit',
        'quantity_used',
        'unit_amount',
        'starting_unit_in_decimal',
        'ending_unit_in_decimal',
        'quantity_used_in_decimal',
        'unit_amount_in_decimal',
    ];
}
