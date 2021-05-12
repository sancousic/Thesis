const Card = {
    render: (name, route) => {
        return `<div class="col">
                    <div class="card mb-1">
                        <div class="card-body">
                            <h4 class="card-title">${name}</h4>
                            <a class="stretched-link" href='${route}'></a>
                        </div>
                    </div>
                </div>`
    }
}