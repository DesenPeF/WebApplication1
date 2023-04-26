
let options = {
    type: 'bar',
    scale: 'hour',
    rows: 4,
    minGridSize: 100,
    startDatetime: "2023-04-24 07:30",
   // endDatetime: "2023-04-24 14:48",
    zoom: true,
    //FORA DA TABELA
    headline: {
        display: true,
        title: 'Ordems',
        range: true,
        local: 'pt-BR',
        format: {
            timeZone: 'UTC',
            hour12: false,
        },
        locale: 'pt-BR',
    },

    //HEADER DA TABELAS
    ruler: {
        truncateLowers: false,
        top: {
            lines: ['month', 'weekday', 'hour'],
            height: 26,
            fontSize: 16,
            color: '#333',
            background: 'transparent',
            locale: 'pt-BR',
            format: {
                timeZone: 'UTC',
                month: 'long',
                weekday: 'long',
                day: 'numeric',
                hour: 'numeric',
            },
        },
    },
    //SIDEBAR
    sidebar: {
        stick: true,
        overlay: true,
        list: [
            '<label>Row Item 1</label>',
            '<label>Row Item 2</label>',
            '<label>Row Item 3</label>',

        ],
    },

    //Show metadata from object show Time in Label
    eventMeta: {
        display: false,
        scale: 'hour',
        locale: 'pt-BR',
        format: {
            timeZone: 'America/Sao_Paulo',
            hour12: false,
        },
        content: '',
    },

    //effects

    // effects: {
    //   presentTime: true,
    //   hoverEvent: true,
    //   stripedGridRow: true,
    //   horizontalGridStyle: 'dotted',
    //   verticalGridStyle: 'solid',
    // },
}


$(document).ready(function () {
    $('#myTimeline').Timeline(options);




    //$('#myTimeline').openEvent({});

})

$('#Scale').on('change', function () {
    console.log(this.value)
    let new_options = {
        
        
       // endDatetime: "auto",
        scale: this.value
    }

    $("#myTimeline").Timeline('reload', new_options, (elm, opts, usrdata) => {
        console.log(usrdata.msg) // show "Changed Timeline Type!" in console
    }, { msg: 'Changed Timeline Type!' })
});
