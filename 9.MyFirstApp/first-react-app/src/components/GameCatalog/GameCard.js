const GameCard = ({
    game,
    navigationChangeHandler
}) => {
    const onDetailsClick = (e) => {
        navigationChangeHandler();
    }
    
    return (
        <div className="allGames">
            <div className="allGames-info">
                <img src={game.imageUrl} />
                <h6>{game.category}</h6>
                <h2>{game.title}</h2>
                <a href="#" onClick={onDetailsClick} className="details-button">Details</a>
            </div>
        </div>
    );
}

export default GameCard;